using System;
using System.Collections.Generic;
using System.Linq;
using TrabajoPractico04.DATA;
using TrabajoPractico04.LOGIC.Interfaces;

namespace TrabajoPractico04.LOGIC
{
    public class CustomersLogic : BaseLogic, IBaseLogic<Customers>, IBaseForString<Customers>
    {
        public void Add(Customers newCustomer)
        {
            try
            {
                context.Customers.Add(newCustomer);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Delete(string id)
        {
            try
            {
                var CustomerAeliminar = context.Customers.SingleOrDefault(c => c.CustomerID == id);
                context.Customers.Remove(CustomerAeliminar);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<Customers> GetAll()
        {
            try
            {
                return context.Customers.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public Customers GetById(string id)
        {
            try
            {
                return context.Customers.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Customers customertoUpdate)
        {
            try
            {
                var customerUpdated = context.Customers.Find(customertoUpdate.CustomerID);

                customerUpdated.CompanyName = customertoUpdate.CompanyName;
                customerUpdated.ContactName = customertoUpdate.ContactName;
                customerUpdated.ContactTitle = customertoUpdate.ContactTitle;
                customerUpdated.Address = customertoUpdate.Address;
                customerUpdated.City = customertoUpdate.City;
                customerUpdated.Region = customertoUpdate.Region;
                customerUpdated.PostalCode = customertoUpdate.PostalCode;
                customerUpdated.Country = customertoUpdate.Country;
                customerUpdated.Phone = customertoUpdate.Phone;
                customerUpdated.Fax = customertoUpdate.Fax;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
