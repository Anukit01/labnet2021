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

        public ActionResult AddAndUpdate(int? id)
        {
            if (id != null)
            {
                var result = logic.GetById((int)id);
                var categoryView = new CategoriesView()
                {
                    Id = result.CategoryID,
                    CategoryName = result.CategoryName,
                    Description = result.Description
                };

                return View(categoryView);
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult AddAndUpdate(CategoriesView category)
        {
            try
            {
                if (category.Id != 0)
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
                else
                {
                    Categories categoryEntity = new Categories
                    {
                        CategoryName = category.CategoryName,
                        Description = category.Description
                    };

                    logic.Add(categoryEntity);
                    return RedirectToAction("Index");
                }
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
    }
}