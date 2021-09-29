using System;
using System.Collections.Generic;
using System.Linq;
using TrabajoPractico04.ENTITIES;
using TrabajoPractico04.LOGIC.Interfaces;

namespace TrabajoPractico04.LOGIC
{
    public class CategoriesLogic : BaseLogic, IBaseLogic<Categories>, IBaseForInt<Categories>
    {
        public void Add(Categories newCategory)
        {
            try
            {
                context.Categories.Add(newCategory);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int id)
        {
            try
            {
                var CategoryAeliminar = context.Categories.FirstOrDefault(c => c.CategoryID == id);
                context.Categories.Remove(CategoryAeliminar);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }                      
            
        }
        public List<Categories> Getall()
        {
            try
            {
            return context.Categories.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Categories GetById(int id)
        {
            try
            {
            return context.Categories.Find(id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
                                  
        }
        public void Update(Categories categoryToUpdate)
        {
            try
            {
                var categoryUpdated = context.Categories.Find(categoryToUpdate.CategoryID);
                categoryUpdated.CategoryName = categoryToUpdate.CategoryName;
                categoryUpdated.Description = categoryToUpdate.Description;
                categoryUpdated.Picture = categoryToUpdate.Picture;
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}
