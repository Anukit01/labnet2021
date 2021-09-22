using System;
using System.Collections.Generic;
using System.Linq;
using TrabajoPractico04.DATA;

namespace TrabajoPractico04.LOGIC
{
    public class CustomersLogic : BaseLogic, IBaseLogic<Customers>
    {
        public void Add(Customers newCustomer)
        {
            context.Customers.Add(newCustomer);
            context.SaveChanges();
        }

        public void Delete(string id)
        {
            var CustomerAeliminar = context.Customers.SingleOrDefault(c => c.CustomerID == id);
            context.Customers.Remove(CustomerAeliminar);

            context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customers> Getall()
        {
            return context.Customers.ToList();
        }
        public Customers GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Customers GetById(string id)
        {
            return context.Customers.Find(id);
        }

        public void Update(Customers customer)
        {
           var customerUpdate = context.Customers.Find(customer.CustomerID);
            context.SaveChanges();
        }
    }
}
