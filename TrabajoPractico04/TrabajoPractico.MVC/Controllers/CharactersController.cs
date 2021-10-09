using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TrabajoPractico.ENTITIES.ExternalApi;
using TrabajoPractico.MVC.Models;
using TrabajoPractico04.LOGIC.ExternalApi;

namespace TrabajoPractico.MVC.Controllers
{
    public class CharactersController : Controller
    {
        CharactersLogic logic = new CharactersLogic();
        public async Task<ActionResult> Index()
        {
            try
            {
                List<CharactersPage> lista = await logic.ShowHarryPotterCharacters();
                return View(lista);
            }
            catch
            {
                return RedirectToAction("Index", "Error");
            }   
        }
        

    }
}   