using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GovApp
{
    /// <summary>
    /// Custom class to validate user input
    /// </summary>
    public class InputValidation
    {
        //Method to validate the location
        public static bool ValidateString(string value)
        {
            if (value.Length > 0)
            {
                return true;
            }
            return false;
        }
        //---------------------------------------------------------------------------//
        //Method to validate the media
        public static bool ValidateMedia(byte[] media)
        {
            if (media.Length > 0)
            {
                return true;
            }
            return false;
        }
        //---------------------------------------------------------------------------//
        //method checks if the string is a number
        public static bool StringNotNumber(string value)
        {
            if (int.TryParse(value, out _) == true)
            {
                MessageBox.Show(""); return false;
            }
            return true;
        }

    }//--------------------------End Of Class-------------------------------------------------//

}//------------------------------End of Namespace---------------------------------------------//
