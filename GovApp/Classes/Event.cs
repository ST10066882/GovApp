using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GovApp.Classes
{
    /// <summary>
    /// Represents what an event entails
    /// </summary>
    public class Event
    {
        //Attributes
        private string _name;
        private string _category;
        private string _date;

        //---------------------------------------------------------------------------//
        // Constructor
        public Event(string name, string category, string date)
        {
            _name = name;
            _category = category;
            _date = date;
        }

        //---------------------------------------------------------------------------//
        // Get the name of the event
        public string GetName()
        {
            return _name;
        }

        //---------------------------------------------------------------------------//
        // Get the category of the event
        public string GetCategory()
        {
            return _category;
        }

        //---------------------------------------------------------------------------//
        // Get the date of the event
        public string GetDate()
        {
            return _date;
        }

        public string ShowEvent() 
        { 
            return "Name: " + _name + "\n" +
                               "Category: " + _category + "\n" + 
                               "Date: " + _date+ "\n" +
                               "---------------------------------";
        }

    }//--------------------------End Of Class-------------------------------------------------//

}//------------------------------End of Namespace---------------------------------------------//
