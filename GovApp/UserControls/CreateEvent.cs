using GovApp.Classes;
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
    /// Data is passed via event manager class
    /// using singleton pattern.
    /// </summary>
    public partial class CreateEvent : UserControl
    {
        //Instance of the InputValidation class
        InputValidation validationClass = new InputValidation();

        //---------------------------------------------------------------------------//
        //Constructor
        public CreateEvent()
        {
            InitializeComponent();
            MyDatePicker.MinDate = DateTime.Today;
            this.Dock = DockStyle.Fill;
        }        

        //---------------------------------------------------------------------------//
        //Creates an event
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if ( ValidateFields() == true )
            {
                //Variable to access dictionary in manager event class
                var eventManager = EventManager.GetInstance();

                //Add the event to the data structures
                eventManager.eventNameSet.Add(nameField.Text);
                eventManager.eventCategorySet.Add(categoryField.Text);
                eventManager.eventDateSet.Add(MyDatePicker.Value.ToString("dd/MM/yyyy"));

                //Create a new event object
                Event newEvent = new Event(nameField.Text, categoryField.Text, MyDatePicker.Value.ToString("dd/MM/yyyy"));

                //Add the event to the dictionary
                eventManager.myEventDict.Add(nameField.Text, newEvent);

                //Display success message for user feedback
                errorLbl.ForeColor = Color.Green;
                errorLbl.Text = "Event Created Successfully";
                //Clear the fields
                ClearFields();
            }
        }

        //---------------------------------------------------------------------------//
        //Validates the fields
        public bool ValidateFields()
        {
            var eventManager = EventManager.GetInstance();

            if (String.IsNullOrEmpty(nameField.Text) || String.IsNullOrEmpty(categoryField.Text) || String.IsNullOrEmpty(MyDatePicker.Text))
            {
                errorLbl.ForeColor = Color.Red;
                errorLbl.Text = "Please fill in all fields";
                return false;
            }
            else if (InputValidation.StringNotNumber(nameField.Text) == false || InputValidation.StringNotNumber(categoryField.Text) == false)
            {
                errorLbl.ForeColor = Color.Red;
                errorLbl.Text = "name or category cant be a number";
                return false;
            } else if ( eventManager.eventNameSet.Contains(nameField.Text) ) 
            {
                errorLbl.ForeColor = Color.Red;
                errorLbl.Text = "Event with that name already exists";
                return false;

            }else if( eventManager.eventDateSet.Contains(MyDatePicker.Text))
            {
                errorLbl.ForeColor = Color.Red;
                errorLbl.Text = "Event with that date already exists";
                return false;
            }
            else {  return true; }
        }

        //---------------------------------------------------------------------------//
        //Empties all fields
        public void ClearFields()
        {
            nameField.Text = "";
            categoryField.Text = "";
            MyDatePicker.Value = DateTime.Today;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }//--------------------------End Of Class-------------------------------------------------//

}//------------------------------End of Namespace---------------------------------------------//
