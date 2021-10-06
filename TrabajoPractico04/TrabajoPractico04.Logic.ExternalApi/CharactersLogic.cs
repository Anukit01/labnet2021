using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TrabajoPractico.ENTITIES.ExternalApi;

namespace TrabajoPractico04.LOGIC.ExternalApi
{
    public class CharactersLogic
    {
        string Baseurl = "http://hp-api.herokuapp.com/";
        public async Task<List<CharactersPage>> ShowHarryPotterCharacters()
        {

            List<CharactersPage> charInfo = new List<CharactersPage>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/characters");
                if (Res.IsSuccessStatusCode)
                {
                    var charResponse = Res.Content.ReadAsStringAsync().Result;
                    charInfo = JsonConvert.DeserializeObject<List<CharactersPage>>(charResponse);
                }

                return charInfo;
            }
        }
    }
}