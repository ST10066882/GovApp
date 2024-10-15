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
    /// used to show the issue details
    /// </summary>
    public partial class ShowIssue : Form
    {
        
        public ShowIssue(string category, string location, string description ,byte[]picture)
        {
            InitializeComponent();
            ErrorLabel.Visible = false;
            //setting the values of the labels and picture box
            CategoryLBl.Text = category;
            LocationLBl.Text = location;
            DescripTxt.Text = description;
            ThePictureBox.Image = CheckDoc(picture);
        }
        //---------------------------------------------------------------------------//
        // Checks if the document is present  telling them it cant be shown
        public Image CheckDoc(byte[] picture)
        {
            try
            {
                Image theImage = Image.FromStream(new System.IO.MemoryStream(picture));
                return theImage;
            }
            catch (Exception ex)
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Document found but wont be displayed";
                return null;
            }
        }
    }//--------------------------End Of Class-------------------------------------------------//

}//------------------------------End of Namespace---------------------------------------------//
