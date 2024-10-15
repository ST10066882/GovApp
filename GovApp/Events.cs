using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GovApp.Classes;
using GovApp.UserControls;

namespace GovApp
{
    /// <summary>
    /// Form to manage events where user can create and view events
    /// thougth the use of different user controls
    /// </summary>
    public partial class Events : Form
    {
        //Create instances of the user controls
        
        

        //---------------------------------------------------------------------------//
        //Constructor
        public Events()
        {
            InitializeComponent();
            //Places the createEvent user control on the content panel
            CreateEvent createEvent = new CreateEvent();
            ContentPanel.Controls.Add(createEvent);
        }
        //---------------------------------------------------------------------------//

        //Closes the form
        private void BackBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //---------------------------------------------------------------------------//
        //Switches to the Create events user control
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.OfType<CreateEvent>().Any())
            {
                //user is on the view events page
                ContentPanel.Controls.Clear();
                CreateEvent createEvent = new CreateEvent();
                
                this.MinimumSize = new Size(836, 612);

                ContentPanel.Controls.Add(createEvent);
            }
        }

        //---------------------------------------------------------------------------//
        //Switches to the View events user control
        private void ViewBtn_Click(object sender, EventArgs e)
        {
            var eventManager = EventManager.GetInstance();
            if (ContentPanel.Controls.OfType<CreateEvent>().Any() && eventManager.myEventDict.Count > 0)
            {
                //user is on the view events page
                ContentPanel.Controls.Clear();
                ViewEvents viewEvents = new ViewEvents();
                
                this.MinimumSize = new Size(961, 568);
                ContentPanel.Controls.Add(viewEvents);
                //MessageBox.Show("category set :" + eventManager.eventCategorySet.Count + "\n date Set :" + eventManager.eventDateSet.Count);

            }
            else {MessageBox.Show("Please create events first!"); }
        }

    }//--------------------------End Of Class-------------------------------------------------//

}//------------------------------End of Namespace---------------------------------------------//
