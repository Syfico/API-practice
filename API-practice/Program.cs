using RestSharp;
using System.Text.Json;
using System.Net;
using System.IO;

RestClient pokeClient = new("https://pokeapi.co/api/v2/");
RestRequest request = new("pokemon/amoonguss");
RestResponse response = pokeClient.GetAsync(request).Result;

if (response.StatusCode == HttpStatusCode.OK)
{
    // File.WriteAllText("./test2.json", response.Content);
    Pokemon p = JsonSerializer.Deserialize<Pokemon>(response.Content);
    Console.WriteLine(p.Name);
    Console.WriteLine(p.Weight);
}
else
{
    Console.WriteLine("What?");
}

// Console.WriteLine(response.Content);

Console.ReadLine();