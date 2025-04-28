
using System.Net.Http;

HttpClient client = new();

string response = await client.GetStringAsync("https://www.thecocktaildb.com/api/json/v1/1/filter.php?c=Coffee%20%2F%20Tea");
Console.WriteLine(response);


//https://www.thecocktaildb.com/api/json/v1/1/popular.php
//www.thecocktaildb.com/api/json/v1/1/list.php?c=list
//https://www.thecocktaildb.com/api/json/v1/1/filter.php?c=Coffee%20%2F%20Tea
