using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GovApp
{
    /// <summary>
    /// backend functionality for the report issue form
    /// </summary>
    public partial class ReportIssue : Form
    {
        private Timer typingTimer = new Timer();
        
        //Trackers for the progress bar
        int locationCounter = 0;
        int comboBoxSelection = 0;
        int mediaCounter = 0;
        int descriptionCounter = 0;

        //Array to store the bytes of user selected file
        byte[] fileBytes;
        //List of categories for the combobox
        List<string> categories = new List<string> { "Select an Option","Roads", "Sanitation", "Electricity", "Health", "Education", "Other" };

        //---------------------------------------------------------------------------//
        //Defualt Constructor
        public ReportIssue()
        {
            InitializeComponent();
            //Populate the combobox with the categories
            CategoryComboBox.DataSource = categories;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowOnly;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Optionally, disable the maximize box
            this.MaximizeBox = false;
        }

        //---------------------------------------------------------------------------//
        //Function to handle the selection of a category
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
        //Function to handle the media button click
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
                    string fileExtension = System.IO.Path.GetExtension(filePath).ToLower();
                    if (fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".jpe" || fileExtension == ".jfif" || fileExtension == ".png")
                    {
                        // Display the image
                        DisplayArea.Image = Image.FromFile(filePath);
                    }
                    //updating the progress bar
                    if (mediaCounter == 0)
                    {
                        MyProgressBar.Value += 25;
                        mediaCounter++;
                    }
                   
                }else //Runs if no file is selected
                {
                    MessageBox.Show("No valid file selected","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                ProgressBarCheck();
            }
        }
        //---------------------------------------------------------------------------//
        //Function to handle the submit button click
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            myTimer.Start();
            MyProgressBar.Value = 0;
            MyProgressBar.ForeColor = Color.Blue;

            //store userInput
            string location = LocationTxtBox.Text;
            string type = CategoryComboBox.SelectedItem.ToString();
            string description = DescriptionTxtbox.Text;
            byte[] media = fileBytes;

            //Validate the input
            if (IssueValidation(location,type,description,media) == true)
            {
                //Create an issue object
                Issue newIssue = new Issue(location, type, description, media);
                //Add the issue to the list via the IssueManager class
                var issueManager = IssueManager.GetInstance();
                issueManager.Issues.Add(newIssue);
                //Tell the user the issue has been submitted
                MessageBox.Show(newIssue.ToString(), "Issue Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Reset the counters and progress bar
                ResetCounters();
                ProgressBarCheck();
            }
        }

        //---------------------------------------------------------------------------//
        //Function to validate the input
        public bool IssueValidation(string location, string type, string description, byte[] media)
        {
            if (InputValidation.ValidateString(location) == false || InputValidation.ValidateString(type) == false || InputValidation.ValidateString(description) == false )
            {
                MessageBox.Show("Please fill in all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }else if (InputValidation.StringNotNumber(location) == false || InputValidation.StringNotNumber(description) == false)
            {
                MessageBox.Show("Location and Description cannot be numbers", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }else if (InputValidation.ValidateMedia(media) == false)
            {
                MessageBox.Show("Please attach an image", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }else if (type == "Select an Option")
            {
                MessageBox.Show("Select a valid category", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }else 
            {
                return true;
            }
        }
        
        //---------------------------------------------------------------------------//
        //Function to handle the back to menuItem button click under navigation
        private void backToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close the form
            Close();
        }

        //---------------------------------------------------------------------------//
        //Function to handle the description text box text change
        private void ProgressStatusLbl_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(LocationTxtBox.Text) == false && String.IsNullOrEmpty(CategoryComboBox.SelectedValue.ToString())==false 
                && String.IsNullOrEmpty(DescriptionTxtbox.Text) == false  && InputValidation.ValidateMedia(fileBytes)==false)
            {
                ProgressStatusLbl.Text = "Ready for Submission";
            }
        }

        //---------------------------------------------------------------------------//
        //What happens when the timer ticks
        private void myTimer_Tick(object sender, EventArgs e)
        {
            if (MyProgressBar.Value < 100)
            {
                MyProgressBar.Value += 10;
                ProgressStatusLbl.Text = "Submitting...";
            }
            else
            {
                myTimer.Stop();
                ProgressStatusLbl.Text = "Well done Submission complete";
            }
        }

        //---------------------------------------------------------------------------//      
        //When user is done typing in location textbox
        private void LocationTxtBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(LocationTxtBox.Text) == false && locationCounter == 0)
            {
                MyProgressBar.Value += 25;
                locationCounter++;
            }
            else if (String.IsNullOrEmpty(LocationTxtBox.Text) == true && locationCounter > 0)
            {
                MyProgressBar.Value -= 25;
                locationCounter = 0;
            }
            ProgressBarCheck();
        }

        //---------------------------------------------------------------------------//
        //When user is done typing in description textbox
        private void DescriptionTxtbox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(DescriptionTxtbox.Text) == false && descriptionCounter == 0)
            {
                MyProgressBar.Value += 25;
                descriptionCounter++;
            }
            else if (String.IsNullOrEmpty(DescriptionTxtbox.Text) == true && descriptionCounter > 0)
            {
                MyProgressBar.Value -= 25;
                descriptionCounter = 0;
            }
            ProgressBarCheck();
        }

        //---------------------------------------------------------------------------//
        // resets progress bar trackers
        public void ResetCounters()
        {
            locationCounter = 0;
            comboBoxSelection = 0;
            mediaCounter = 0;
            descriptionCounter = 0;
            MyProgressBar.Value = 0;
        }

        //---------------------------------------------------------------------------//
        //Function to check the progress bar value and update the progress status label
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

        private void ReportIssue_Load(object sender, EventArgs e)
        {
            System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;

            this.Size = new System.Drawing.Size(Convert.ToInt32(workingRectangle.Width * 0.5), Convert.ToInt32(workingRectangle.Height * 0.5));

            this.Location = new Point(10,10);
        }

        private void DescriptionTxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }//--------------------------End Of Class-------------------------------------------------//

}//------------------------------End of Namespace---------------------------------------------//
