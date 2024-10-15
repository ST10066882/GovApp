using GovApp.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GovApp.UserControls
{
    /// <summary>
    /// User control to view events and provide
    /// reccomendations based on previous user searches.
    /// </summary>
    public partial class ViewEvents : UserControl
    {
        //Variables to store data passed from Event-Form
        private HashSet<string> _nameSet;
        private HashSet<string> _categorySet;
        private HashSet<string> _dateSet;

        Queue<Event> myQueue = new Queue<Event>();

        //---------------------------------------------------------------------------//
        //Constructor
        public ViewEvents()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            //Populates sets with data from the event manager
            _nameSet = EventManager.GetInstance().eventNameSet;
            _categorySet = EventManager.GetInstance().eventCategorySet;
            _dateSet = EventManager.GetInstance().eventDateSet;
            //populates the comboboxes
            PopulateEventCombobox();
            PopulateDateCombobox();
        }

        //---------------------------------------------------------------------------//
        //Populates the listbox with the events
        public void PopulateEventCombobox()
        {
            //Populates the listbox with the events
            if (_categorySet != null && _categorySet.Any())
            {
                EventCategorySelection.Items.AddRange(_categorySet.OrderBy(name => name).ToArray());
            }
        }

        //---------------------------------------------------------------------------//
        //Populates the date combobox with the events
        public void PopulateDateCombobox()
        {
            //Populates date combox with and orders it by earliest to latest
            if (_dateSet != null && _dateSet.Any())
            {
                DateSelectionBox.Items.AddRange(
                    _dateSet
                    .Select(date => DateTime.ParseExact(date, "dd/MM/yyyy", null))
                    .OrderBy(date => date)
                    .Select(date => date.ToString("dd/MM/yyyy"))
                    .ToArray()
                );
            }
        }

        //---------------------------------------------------------------------------//
        //functionailty to search for events
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            //Storing the search criteria
            string date = DateSelectionBox.SelectedItem?.ToString();
            string category = EventCategorySelection.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(category) && string.IsNullOrEmpty(date))
            {
                errorLbl.ForeColor = Color.Red;
                errorLbl.Text = "select at least one of the fields to search by";
            }
            else
            {
                EventBox.Clear();
                List<Event> searchResults = null;
                //Storing search history
                EventManager.GetInstance().searchHistory.Add(new SearchRecord(date, category));
                //Picking correct search based on user input
                searchResults = SearchDictioanry(searchResults, date, category);
                // Check if any events were found by search 
                if (searchResults != null && searchResults.Count > 0)
                {
                    DisplayProcess(searchResults, myQueue);
                    errorLbl.Text = "";
                    if ( EventManager.GetInstance().searchHistory.Count > 1 )
                    {
                        //Run search algorithm to provide reccomendations
                        SearchAlgorithim();
                    }
                    ResetFields();
                }
                else
                {
                    //If no events are found by search display error message
                    errorLbl.ForeColor = Color.Red;
                    errorLbl.Text = "No events found";
                    ResetFields();
                }
            }
        }

        //---------------------------------------------------------------------------//
        //Search algorithm to provide reccomendations based on previous searches
        public void SearchAlgorithim()
        {
            //Clear the reccomendation box of any previous reccomendations
            reccomendBox.Clear();
            //Get the search history
            List<SearchRecord>searchHistory = EventManager.GetInstance().searchHistory;

            // Count the how many times the user has searched by certina date or category
            var dateFrequency = searchHistory.Where(r => r.GetDate() != null).GroupBy(r => r.GetDate())
                .OrderByDescending(g => g.Count()).FirstOrDefault();

            var categoryFrequency = searchHistory.Where(r => r.GetCategory() != null).GroupBy(r => r.GetCategory())
                                                 .OrderByDescending(g => g.Count()).FirstOrDefault();

            //Display reccomendations
            DisplayReccomendation(dateFrequency,categoryFrequency,searchHistory);
        }

        //------------------------------------------------------------------------------------------------------------------------------------//
        //How reccomendations are displayed
        public void DisplayReccomendation(IGrouping<string, SearchRecord> dateFrequency, IGrouping<string,
                                          SearchRecord> categoryFrequency, List<SearchRecord> searchHistory)
        {
            reccomendBox.SelectionFont = new Font("Bold", 14, FontStyle.Bold);
            reccomendBox.AppendText("Reccomendations\n");
            reccomendBox.SelectionFont = new Font("Arial", 12, FontStyle.Regular);
            reccomendBox.AppendText("----------------------------------------------------------------------\n");

            //Storing condition in variable for readability
            bool RecommendationDate = dateFrequency != null && dateFrequency.Count() > 1;
            bool RecommendationCategory = categoryFrequency != null && categoryFrequency.Count() > 1;

            // Responses based for each case of reccomendations 
            if (RecommendationDate && RecommendationCategory)
            {
                reccomendBox.SelectionFont = new Font("Arial", 12, FontStyle.Regular);
                reccomendBox.AppendText($"We recommend searching by Date: {dateFrequency.Key}.\n");

            }
            else if (RecommendationDate)
            {
                reccomendBox.SelectionFont = new Font("Arial", 12, FontStyle.Regular);
                reccomendBox.AppendText($"We recommend searching by Category: {categoryFrequency.Key}.\n");

            }
            else if (RecommendationCategory)
            {
                reccomendBox.SelectionFont = new Font("Arial", 12, FontStyle.Regular);
                reccomendBox.AppendText($"We recommend searching by Date: {dateFrequency.Key} and Category: {categoryFrequency.Key}.\n");
            }
            else
            {
                var lastSearch = searchHistory.Last();
                reccomendBox.SelectionFont = new Font("Arial", 12, FontStyle.Regular);
                reccomendBox.AppendText($"you could try Date: {lastSearch.GetDate()} or Category: {lastSearch.GetCategory()}.\n");
            }
            reccomendBox.SelectionFont = new Font("Arial", 12, FontStyle.Regular);
            reccomendBox.AppendText("-----------------------------------------------------------------------\n");
        }

        //---------------------------------------------------------------------------//
        //Picking correct search based on provided user input
        public List<Event> SearchDictioanry(List<Event> searchResults, string date ,string category)
        {  
            if (date != null && category != null)
            {
                //searching for events by category and date
                searchResults = EventManager.GetInstance().myEventDict.Values
                    .Where(entry => entry.GetDate() == date && entry.GetCategory() == category)
                    .OrderBy(entry => entry.GetName()).ToList<Event>();

            }
            else if (date != null)
            {
                //searching for events by date only
                searchResults = EventManager.GetInstance().myEventDict.Values
                    .Where(entry => entry.GetDate() == date)
                    .OrderBy(entry => entry.GetName()).ToList<Event>();
            }
            else if (category != null)
            {
                //searching for events by category only 
                searchResults = EventManager.GetInstance().myEventDict.Values
                    .Where(entry => entry.GetCategory() == category)
                    .OrderBy(entry => entry.GetName()).ToList<Event>();
            }
            return searchResults;
        }

        //---------------------------------------------------------------------------//
        //alternate between what users can search by
        public void DisplayProcess(List<Event> Results,Queue<Event> theQueue) 
        {
            Results.ForEach( eventItem => theQueue.Enqueue(eventItem));
            //place the events in the listbox one by one
            while (theQueue.Count > 0)
            {
                Event eventItem = theQueue.Dequeue(); 
                FormatOutput(eventItem); 
            }
        }

        //---------------------------------------------------------------------------//
        //Displays output in the event box in a formatted way
        public void FormatOutput(Event currentEvent)
        {
            EventBox.SelectionFont = new Font("Arial", 14, FontStyle.Bold);
            EventBox.AppendText($"Name: {currentEvent.GetName()}\n");

            EventBox.SelectionFont = new Font("Arial", 12, FontStyle.Regular);  
            EventBox.AppendText("--------------------------------------------------------------------------------\n");
            EventBox.AppendText("\n");

            EventBox.SelectionFont = new Font("Bold", 12, FontStyle.Bold);
            EventBox.AppendText("Category: ");

            EventBox.SelectionFont = new Font("Arial", 12, FontStyle.Regular);
            EventBox.AppendText($"{currentEvent.GetCategory()}\n");

            EventBox.SelectionFont = new Font("Bold", 12, FontStyle.Bold);
            EventBox.AppendText("Date: ");

            EventBox.SelectionFont = new Font("Arial", 12, FontStyle.Regular);
            EventBox.AppendText($"        {currentEvent.GetDate()}\n");

            EventBox.AppendText("\n");
            EventBox.SelectionFont = new Font("Arial", 12, FontStyle.Regular);
            EventBox.AppendText("--------------------------------------------------------------------------------\n");
        }
        
        //---------------------------------------------------------------------------//
        //clears the fields
        public void ResetFields()
        {
            EventCategorySelection.Enabled = true;
            DateSelectionBox.Enabled = true;
            EventCategorySelection.SelectedItem = null;
            DateSelectionBox.SelectedItem = null;
            errorLbl.Text = "";
        }

    }//--------------------------End Of Class-------------------------------------------------//

}//------------------------------End of Namespace---------------------------------------------//
