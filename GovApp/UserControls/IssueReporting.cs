using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GovApp.UserControls
{
    /// <summary>
    /// User Control holding functionality for the Issue Reporting form
    /// </summary>
    public partial class IssueReporting : UserControl
    {
        //Trackers for the progress bar
        int locationCounter = 0;
        int comboBoxSelection = 0;
        int mediaCounter = 0;
        int descriptionCounter = 0;

        //Array to store the bytes of user selected file
        byte[] fileBytes;
        //List of categories for the combobox
        List<string> categories = new List<string> { "Select an Option", "Roads", "Sanitation", "Electricity", "Health", "Education", "Other" };

        //Defualt constructor
        public IssueReporting()
        {
            InitializeComponent();
            //Populate the combobox with the categories
            CategoryComboBox.DataSource = categories;
            ProgressBarCheck();
        }

        //---------------------------------------------------------------------------//
        //  This is the code for the Return button on the Issue Reporting form.      //
        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            IssueCreation issueCreation = this.FindForm() as IssueCreation;
            // Close the form
            if (issueCreation != null)
            {
                issueCreation.Close();
            }
        }

        //---------------------------------------------------------------------------//
        //  Code when user selects new option in combo box   
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If the user selects "Select an Option", decrease progress if they had previously selected something valid
            if (comboBoxSelection > 0 && CategoryComboBox.SelectedValue.ToString() == "Select an Option")
            {
                MyProgressBar.Value -= 25;
                comboBoxSelection = 0;
            }
            // If a valid option is selected and it hasn’t contributed to progress yet
            else if (comboBoxSelection == 0 && CategoryComboBox.SelectedValue.ToString() != "Select an Option")
            {
                MyProgressBar.Value += 25;
                comboBoxSelection++;
            }
            ProgressBarCheck();
        }

        //---------------------------------------------------------------------------//
        // Checks the progress bar status
        public void ProgressBarCheck()
        {
            switch (MyProgressBar.Value)
            {
                case 0:
                    ProgressStatusLbl.Text = "Report a new Issue";
                    MyProgressBar.Visible = false;
                    break;
                case 25:
                    ProgressStatusLbl.Text = "Progress is progress";
                    MyProgressBar.Visible = true;
                    break;
                case 50:
                    ProgressStatusLbl.Text = "Half way there";
                    MyProgressBar.Visible = true;
                    break;
                case 75:
                    ProgressStatusLbl.Text = "Just a little bit more";
                    MyProgressBar.Visible = true;
                    break;
                case 100:
                    ProgressStatusLbl.Text = "Ready for Submission";
                    break;
            }
        }

        //---------------------------------------------------------------------------//
        //  Code for the Submit button on the Issue Reporting form.
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            MyTimer.Start();
            MyProgressBar.Value = 0;
           
            //store userInput
            string location = LocationTxt.Text;
            string type = CategoryComboBox.SelectedItem.ToString();
            string description = DescriptionTxt.Text;
            byte[] media = fileBytes;

            //Validate the input
            if (IssueValidation(location, type, description, media) == true)
            {
                //Create an issue object
                Issue newIssue = new Issue(location, type, description, media);
                //Add the issue to the list via the IssueManager class
                var issueManager = IssueManager.GetInstance();
                issueManager.Issues.Add(newIssue);
                //Tell the user the issue has been submitted                
                ShowIssue showIssue = new ShowIssue(newIssue.Type, newIssue.Location, newIssue.Description, newIssue.MediaPath);
                showIssue.ShowDialog();            
                //Reset the counters and progress bar
                ProgressBarCheck();
                ResetCounters();
                //Empty the fields
                ClearFields();
                ProgressBarCheck();
            }
        }

        //---------------------------------------------------------------------------//
        //  Code for the Media button on the Issue Reporting form.
        private void MediaBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //Applies a filter to the file dialog
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png | Document files (*.pdf, *.docx, *.txt) | *.pdf; *.docx; *.txt";
                //Checks if the user selected a file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    string filePath = openFileDialog.FileName;
                    //Read the bytes of the file
                    fileBytes = System.IO.File.ReadAllBytes(filePath);
                    //Use file extension to determine the type of file
                    string fileExtension = System.IO.Path.GetExtension(filePath).ToLower();

                    //Check if the file is an image
                    if (fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".jpe" || fileExtension == ".jfif" || fileExtension == ".png")
                    {
                        // Display the image
                        MyPictureBox.Image = Image.FromFile(filePath);
                    }
                    //updating the progress bar
                    if (mediaCounter == 0)
                    {
                        MyProgressBar.Value += 25;
                        mediaCounter++;
                    }

                }
                else //Runs if no file is selected
                {
                    //MessageBox.Show("No valid file selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ProgressStatusLbl.Text = "No valid file selected";
                }
                ProgressBarCheck();
            }
        }

        //---------------------------------------------------------------------------//
        //  Function to validate the user input
        public bool IssueValidation(string location, string type, string description, byte[] media)
        {
            if (InputValidation.ValidateString(location) == false || InputValidation.ValidateString(type) == false || InputValidation.ValidateString(description) == false)
            {
                //MessageBox.Show("Please fill in all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ProgressStatusLbl.Text = "Please fill in all fields";
                return false;
            }
            else if (InputValidation.StringNotNumber(location) == false || InputValidation.StringNotNumber(description) == false)
            {
                //MessageBox.Show("Location and Description cannot be numbers", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ProgressStatusLbl.Text = "Location and Description cannot be numbers";
                return false;

            }
            else if (InputValidation.ValidateMedia(media) == false)
            {
                //MessageBox.Show("Please attach an image or file", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ProgressStatusLbl.Text = "Please attach an image or file";
                return false;
            }
            else if (type == "Select an Option")
            {
                //MessageBox.Show("Select a valid category", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ProgressStatusLbl.Text = "Select a valid category";
                return false;
            }
            else
            {
                return true;
            }
        }

        //---------------------------------------------------------------------------//
        //  Reset the counters and progress bar
        public void ResetCounters()
        {
            locationCounter = 0;
            comboBoxSelection = 0;
            mediaCounter = 0;
            descriptionCounter = 0;
            MyProgressBar.Value = 0;
        }
        //---------------------------------------------------------------------------//
        //  Clear the fields
        public void ClearFields()
        {
            LocationTxt.Clear();
            CategoryComboBox.SelectedIndex = 0;
            DescriptionTxt.Clear();
            MyPictureBox.Image = null;
            fileBytes = null;
        }

        //---------------------------------------------------------------------------//
        //  Function handleing progress bar as timer ticks
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            if (MyProgressBar.Value < 100)
            {
                MyProgressBar.Value += 10;
                ProgressStatusLbl.Text = "Submitting...";
            }
            else
            {
                MyTimer.Stop();
                ProgressStatusLbl.Text = "Well done Submission complete";
            }
        }

        //---------------------------------------------------------------------------//
        // Function to indicate when user is satisfied with the location
        private void LocationTxt_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(LocationTxt.Text) == false && locationCounter == 0)
            {
                MyProgressBar.Value += 25;
                locationCounter++;
            }
            else if (String.IsNullOrEmpty(LocationTxt.Text) == true && locationCounter > 0)
            {
                MyProgressBar.Value -= 25;
                locationCounter = 0;
            }
            ProgressBarCheck();
        }

        //---------------------------------------------------------------------------//
        // Function to indicate when user is satisfied with the description
        private void DescriptionTxt_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(DescriptionTxt.Text) == false && descriptionCounter == 0)
            {
                MyProgressBar.Value += 25;
                descriptionCounter++;
            }
            else if (String.IsNullOrEmpty(DescriptionTxt.Text) == true && descriptionCounter > 0)
            {
                MyProgressBar.Value -= 25;
                descriptionCounter = 0;
            }
            ProgressBarCheck();
        }

        private void LocationTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProgressStatusLbl_Click(object sender, EventArgs e)
        {

        }
    }//--------------------------End Of Class-------------------------------------------------//

}//------------------------------End of Namespace---------------------------------------------//
