using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TrabajoPractico.MVC.Models;

namespace TrabajoPractico.MVC.Controllers
{
    public class CharactersController : Controller
    {
        string Baseurl = "http://hp-api.herokuapp.com/";
        // GET: Characters
        public async Task<ActionResult> Index()
        {

            List<CharactersView> charInfo = new List<CharactersView>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/characters");
                if (Res.IsSuccessStatusCode)
                {
                    var charResponse = Res.Content.ReadAsStringAsync().Result;
                    charInfo = JsonConvert.DeserializeObject<List<CharactersView>>(charResponse);
                }
               
                return View(charInfo);
            }
        }

    }
}   