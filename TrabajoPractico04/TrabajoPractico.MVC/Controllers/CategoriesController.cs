using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabajoPractico.MVC.Models;
using TrabajoPractico04.ENTITIES;
using TrabajoPractico04.LOGIC;

namespace TrabajoPractico.MVC.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        CategoriesLogic logic = new CategoriesLogic();
        public ActionResult Index()
        {
            List<Categories> category = logic.GetAll();
            List<CategoriesView> categoryView = category.Select(cat => new CategoriesView
            {
                Id = cat.CategoryID,
                CategoryName = cat.CategoryName,
                Description = cat.Description,
            }).ToList();
            return View(categoryView);
        }

        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(CategoriesView categoriesView)
        {
            try
            {
                Categories categoryEntity = new Categories
                {
                    CategoryName = categoriesView.CategoryName,
                    Description = categoriesView.Description
                };

                logic.Add(categoryEntity);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");

            }
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            logic.Delete(id);
            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {
            var result = logic.GetById(id);
            var categoryView = new CategoriesView()
            {
                Id = result.CategoryID,
                CategoryName = result.CategoryName,
                Description = result.Description
            };

            return View(categoryView);
        }
        [HttpPost]
        public ActionResult Update(CategoriesView category)
        {                  
                var categoryToUpdate = new Categories()
                {
                    CategoryID = category.Id,
                    CategoryName = category.CategoryName,
                    Description = category.Description
                };

                logic.Update(categoryToUpdate);
            
            return RedirectToAction("Index");
        }
    }
}