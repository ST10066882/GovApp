using GovApp.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GovApp
{
    public partial class ServiceRequestStatus : Form
    {
        // Constructor
        public ServiceRequestStatus()
        {
            InitializeComponent();
            ServiceLocator serviceLocator = new ServiceLocator();
            //Places the ServiceLocator user control on the content panel
            ContentPanel.Controls.Add(serviceLocator);
        }

        //---------------------------------------------------------------------------//
        // functionailty for the back button
        private void BackBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
