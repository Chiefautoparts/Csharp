using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace pokeInfo
{
    public class WebRequest
    {
        public static async Task GetPokemonDataAsync(int PokeId, Action<Dictionary<string, object>> Callback)
        {
            using (var Client = new HttpClient())
            {
                try
                {
                    Client.BaseAddress = new Uri($"http://pokeapi.com/api/v2/pokemon/{PokeId}");
                    HttpResponseMessage Response = await Client.GetAsync("");
                    Response.EnsureSuccessStatusCode();
                    string StringResponse = await Response.Content.ReadAsStringAsync();
                    JObject PokeInfo = JsonConvert.DeserializeObject<JObject>(StringResponse);
                    JArray TypeList = PokeInfo["types"].Value<JArray>();
                    List<string> Types = new List<string>();

                    foreach(JObject TypeObject in TypeList)
                    {
                        Types.Add(TypeObject["type"]["name"].Value<string>());
                    }

                    Pokemans PokeData = new Pokemans{
                        Name = PokeInfo["name"].Value<string>(),
                        Weight = PokeInfo["weight"].Value<long>(),
                        Height = PokeInfo["height"].Value<long>(),
                        Types = Types

                    };

                    Callback(Pokemans);
        
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Request exception: {e.Message}");
                }
            }
        }
    }
}