using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DrinkInfo.Model
{
    public class Drinks
    {
        [JsonProperty("drinks")]

        public List<Drink> DrinkList {get; set;}

    }

    public class Drink
    {
        public string idDrink {get; set;}
        public string strDrink {get; set;}
    }
}
