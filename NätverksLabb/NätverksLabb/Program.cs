using System;
using RestSharp;
using System.Text.Json;


RestClient pokeClient = new RestClient("https://pokeapi.co/api/v2/");

Console.WriteLine("Write Pokemon: ");

string ownPokemon = Console.ReadLine();


RestRequest pokeRequest = new RestRequest($"pokemon/{ownPokemon}");

IRestResponse response = pokeClient.Get(pokeRequest);

//Console.WriteLine(response.StatusCode);
//Console.WriteLine(response.Content);

pokeKlass poke = JsonSerializer.Deserialize<pokeKlass>(response.Content);

Console.WriteLine($"Name: {poke.name}  id: {poke.id}");


Console.ReadLine();