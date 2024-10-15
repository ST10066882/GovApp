using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace GovApp
{
    public partial class MainForm : Form
    {
        //List of services populated in the combo box
        List<String> services = new List<String> 
        {"Select an Option","Report Issue", "Local Events & Announcements", "Service Request Status" };

        Form childForm = null;
        //Default constructor
        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            //Populate the combo box with the services
            WindowSelectorcComboBox.DataSource = services;
            this.BackgroundImage = Properties.Resources.south_africa;
            this.WindowState = FormWindowState.Maximized;
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }
        //---------------------------------------------------------------------------//

        private void MainForm_Load(object sender, EventArgs e)
        {
            Refresh();
        }
        
        //---------------------------------------------------------------------------//
        //Method to handle the selection of a service
        private void WindowSelectorcComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected service
            string choice = WindowSelectorcComboBox.SelectedItem.ToString();
            if (choice== "Select an Option")
            {
                return;
            }           
            // Close all child forms
            CloseChildForm();
            // Check if a service is selected
            if (string.IsNullOrEmpty(choice))
            {
                MessageBox.Show("Please select a service to view");
            }
            else //Runs if a service is selected
            {
                //Valid options
                switch (choice)
                {
                    case "Report Issue":
                        childForm = new IssueCreation();
                        ChildFormSetup();
                        break;
                    case "Local Events & Announcements":
                        childForm = new Events();
                        ChildFormSetup();
                        //MessageBox.Show("Feature comming soon");
                        break;
                    case "Service Request Status":
                        MessageBox.Show("Feature comming soon");
                        break;
                }
                 
            }
        }

        //---------------------------------------------------------------------------//
        //sets window as child inside parent
        public void ChildFormSetup()
        {
            // Set the MDI parent
            childForm.MdiParent = this;
            // Maximizes the child window
            //childForm.WindowState = FormWindowState.Maximized;
            // Displays child inside main form
            WindowSelectorcComboBox.Visible = false;
            MainHeadingLbl.Visible = false;
            //Rests parent  combo box when child form is closed
            childForm.FormClosed += ResetHome;
            //finally display it
            childForm.Show();
            childForm.BringToFront();  // Bring the child form to the front
            childForm.Activate();  // Activate the child form, making it fully on top
        }
        
        //---------------------------------------------------------------------------//
        //Method to close all child forms
        public void CloseChildForm()
        {
            // Close all child forms
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
        }   

        //---------------------------------------------------------------------------//
        //Method to handle the closing of the child form
        private void ResetHome(object sender, FormClosedEventArgs e)
        {
            // Make the ComboBox and MainHeading visible again when the child form is closed
            WindowSelectorcComboBox.Visible = true;
            MainHeadingLbl.Visible = true;
            
            // Optionally reset the ComboBox selection to the default
            WindowSelectorcComboBox.SelectedIndex = 0; // Resets to "Select an Option"
        }

        //---------------------------------------------------------------------------//
        //exit the application
        private void exitAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        //---------------------------------------------------------------------------//
        //Method to handle the click event of the report issue menu item
        private void ReportIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm = new IssueCreation();
            ChildFormSetup(); 
        }

        //---------------------------------------------------------------------------//
        //Method to handle the click event of the local events menu item
        private void eventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm = new Events();   
            ChildFormSetup();
        }
    }//--------------------------End Of Class-------------------------------------------------//

}//------------------------------End of Namespace---------------------------------------------//
