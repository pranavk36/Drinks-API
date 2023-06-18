using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using drinks_info.Models;
using Newtonsoft.Json;
using RestSharp;

namespace drinks_info
{
    public class DrinksService
    {
        public void GetCategories(){
            var client = new RestClient("https://www.thecocktaildb.com/api/json/v1/1");
            var request = new RestRequest("list.php?c=list");
            var response = client.ExecuteAsync(request);

            if(response.Result.StatusCode == System.Net.HttpStatusCode.OK){
                var rawResponse = response.Result.Content;
                var serialize = JsonConvert.DeserializeObject<Categories>(rawResponse);

                List<Category> returnedList = serialize.CategoriesList;

                Visualiser.ShowTable(returnedList, "Categories Menu");
            }
        }
    }
}