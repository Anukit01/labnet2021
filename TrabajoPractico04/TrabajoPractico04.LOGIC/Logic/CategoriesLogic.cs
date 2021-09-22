using System;
using System.Collections.Generic;
using System.Linq;
using TrabajoPractico04.ENTITIES;

namespace TrabajoPractico04.LOGIC
{
    public class CategoriesLogic : BaseLogic, IBaseLogic<Categories>
    {
        public void Add(Categories newCategory)
        {
            context.Categories.Add(newCategory);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var CategoryAeliminar = context.Categories.FirstOrDefault(c => c.CategoryID == id);

            context.Categories.Remove(CategoryAeliminar);

            context.SaveChanges();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Categories> Getall()
        {
            return context.Categories.ToList();
        }

        public Categories GetById(int id)
        {
            return context.Categories.Find(id);
        }

        public Categories GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(Categories category)
        {
            var categoriesUpdate = context.Categories.Find(category.CategoryID);
            context.SaveChanges();
        }

        
    }
}
