using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using unirest_net.http;
using Newtonsoft.Json;

namespace API.Model
{
    public class DataService : IDataService
    {
        async public HttpResponse<FilmInfo> GetData(Action<DataItem, Exception> callback)
        {
            // Use this to connect to the actual data service
            Task<HttpResponse<FilmInfo>> response = await Unirest.get("https://community-netflix-roulette.p.mashape.com/api.php?title=House+of+cards")
            .header("X-Mashape-Key", "NHJCq0vKpBmshAcHlKjrnxOivSyIp1Q3ionjsnwy86Z90g3rXA")
            .header("Accept", "application/json")
            .asJson<FilmInfo>();
            return response;
            

          //  var item = new DataItem("Welcome to MVVM Light");
           // callback(item, null);
        }

        public List<DataItem> ConvertToDomainModel(List<FilmInfo> films)
        {
            List<DataItem> list_of_films = new List<DataItem>();
            foreach (var film in films)
            {
                list_of_films.Add(new DataItem(film.Title,film.ReleaseYear,film.Rating,film.Summary));
            }
            return list_of_films;
        }
    }
}