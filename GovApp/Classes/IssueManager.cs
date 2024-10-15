using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GovApp
{
    /// <summary>
    /// Manages the list of issues by implementing the singleton pattern that ensures only one instance
    /// of the class is created and shared accross the entire application.
    /// </summary>
    public class IssueManager
    {
        // The singleton instance of the issue manager
        private static IssueManager _instance;

        // The list of issues
        public List<Issue> Issues { get; private set; }

        //---------------------------------------------------------------------------//

        // Private constructor to prevent instantiation
        private IssueManager()
        {
            Issues = new List<Issue>();
        }

        //---------------------------------------------------------------------------//

        // Public method to get the singleton instance
        public static IssueManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new IssueManager();
            }
            return _instance;
        }

    }//--------------------------End Of Class-------------------------------------------------//

}//------------------------------End of Namespace---------------------------------------------//
