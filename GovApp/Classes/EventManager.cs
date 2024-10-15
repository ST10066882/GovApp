using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GovApp.Classes
{
    /// <summary>
    /// maganages the events by implementing
    /// the singleton pattern that ensures only one
    /// instance per run.
    /// </summary>
    public class EventManager
    {
        private static EventManager myInstance;
        public Dictionary<string, Event> myEventDict;
        //Sets to store event data
        public HashSet<string> eventNameSet;
        public HashSet<string> eventCategorySet;
        public HashSet<string> eventDateSet;
        //List to store search history
        public List<SearchRecord> searchHistory;

        //---------------------------------------------------------------------------//
        // Private constructor prevents instantiation
        private EventManager()
        {
            myEventDict = new Dictionary<string, Event>();
            eventNameSet = new HashSet<string>();
            eventCategorySet = new HashSet<string>();
            eventDateSet = new HashSet<string>();
            searchHistory = new List<SearchRecord>();
        }

        //---------------------------------------------------------------------------//
        // Get the singleton instance
        public static EventManager GetInstance()
        {
            if (myInstance == null)
            {
                myInstance = new EventManager();
            }
            return myInstance;
        }

    }//--------------------------End Of Class-------------------------------------------------//

}//------------------------------End of Namespace---------------------------------------------//
