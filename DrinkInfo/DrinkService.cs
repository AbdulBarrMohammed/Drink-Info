using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using DrinkInfo.Model;
using Newtonsoft.Json;
using RestSharp;

namespace DrinkInfo
{
    public class DrinkService
    {

        public void GetCategories()
        {
            var client = new RestClient("https://www.thecocktaildb.com/api/json/v1/1/");
            var request = new RestRequest("list.php?c=list");
            var response = client.ExecuteAsync(request);

            if (response.Result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Result.Content;
                var serialize = JsonConvert.DeserializeObject<Categories>(rawResponse);

                List<Category> returnedList = serialize.CategoriesList;

                TableVisualisationEngine.ShowTable(returnedList, "Categories Menu");
            }
        }
    }
}
