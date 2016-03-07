using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Model
{
    [JsonObject]
   public class FilmInfo
    {
        /*"unit": 7474,
  "show_id": 70153391,
  "show_title": "The Boondocks",
  "release_year": "2005",
  "rating": "4.0",
  "category": "TV Shows",
  "show_cast": "Regina King, John Witherspoon, Cedric Yarbrough, Gary Anthony Williams, Jill Talley, Gabby Soleil",
  "director": "",
  "summary": "Based on the comic strip by Aaron McGruder, this satirical animated series follows the socially conscious misadventures of Huey Freeman, a preternaturally smart 10-year-old who relocates from inner-city Chicago to the suburbs.",
  "poster": "http://netflixroulette.net/api/posters/70153391.jpg",
  "mediatype": 1,
  "runtime"
         */
        [JsonProperty ("show_title")]
        public string Title { get; set; }
        [JsonProperty("release_year")]
        public int ReleaseYear { get; set; }
        [JsonProperty ("rating")]
        public int Rating { get; set; }
        [JsonProperty("summary")]
        public string Summary { get; set; }
    }
}
