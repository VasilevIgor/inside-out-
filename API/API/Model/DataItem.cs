using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace API.Model
{
    public class DataItem
    {
        public DataItem(string title, int release, int rating, string summary) 
        {
            Title = title;
            ReleaseYear = release;
            Rating = rating;
            Summary = summary;
        }

        public string Title
        {
            get;
            private set;
        }
       
        public int ReleaseYear { get; private  set; }
        public int Rating { get; private  set; }
        public string Summary { get; private set; }
    }
}
