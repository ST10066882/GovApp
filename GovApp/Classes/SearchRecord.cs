using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GovApp.Classes
{
    public class SearchRecord
    {
        private string date;
        private string category;

        public SearchRecord(string date, string category)
        {
            this.date = string.IsNullOrEmpty(date) ? null : date;
            this.category = string.IsNullOrEmpty(category) ? null : category;
        }

        public string GetDate()
        {
            return date;
        }

        public string GetCategory() 
        {
            return category;
        }
    }
}
