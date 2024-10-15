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
    /// <summary>
    /// creating issue form frontend note usercontrol has the logic
    /// </summary>
    public partial class IssueCreation : Form
    {
        IssueReporting issueReporting = new IssueReporting();
        
        //---------------------------------------------------------------------------//
        //Default constructor
        public IssueCreation()
        {
            InitializeComponent();
            //Place user control on the form
            issueReporting.Dock = DockStyle.Fill;
            this.Controls.Add(issueReporting);
            issueReporting.BringToFront();
        }
        //---------------------------------------------------------------------------//
        //method handeling the form load
        private void IssueCreation_Load(object sender, EventArgs e)
        {
            //minimum size of the form
            this.MinimumSize = new Size(776, 552);
        }

    }//--------------------------End Of Class-------------------------------------------------//

}//------------------------------End of Namespace---------------------------------------------//
