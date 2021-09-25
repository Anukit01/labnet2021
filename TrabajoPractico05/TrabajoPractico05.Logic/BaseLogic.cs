using System;
using System.Collections.Generic;
using System.Linq;
using TrabajoPractico05.Data;
using TrabajoPractico05.Entities;

namespace TrabajoPractico05.Logic
{
    public class BaseLogic
    {
        protected readonly NorthwindContext context;
        public BaseLogic()
        {
            context = new NorthwindContext();
        }
        public Customers Query1()
        {
            Customers query1 = context.Customers.FirstOrDefault();
            return query1;
        }
        public List<Products> Query2()
        {
            var query2 = (from product in context.Products
                          where product.UnitsInStock == 0
                          select product).ToList();
            return query2;
        }
        public List<Products> Query3()
        {
            var query3 = (from product in context.Products
                          where product.UnitsInStock != 0 && product.UnitPrice > 3
                          select product).ToList();
            return query3;
        }
        public List<Customers> Query4()
        {
            var query4 = context.Customers
                                .Where(c => c.Region == "WA")
                                .Select(c => c).ToList();
            return query4;
        }
        public Products Query5()
        {
            Products query5 = context.Products
                                     .FirstOrDefault(p => p.CategoryID == 789);
            return query5;
        }
        public List<string> Query6A()
        {

            var query6A = (from Customer in context.Customers
                           select Customer.ContactName.ToUpper()).ToList();
            return query6A;
        }
        public List<string> Query6B()
        {

            var query6B = (from Customer in context.Customers
                           select Customer.ContactName.ToLower()).ToList();
            return query6B;
        }
        public List<object> Query7()
        {
            var query7 = context.Orders.Join(context.Customers,
                                            o => o.CustomerID,
                                            c => c.CustomerID,
                                            (o, c) => new { Orders = o, Customers = c })
                                       .Where(oc => oc.Customers.Region == "WA" &&
                                           oc.Orders.OrderDate > new DateTime(1997, 1, 1, 0, 0, 0))
                                       .Select(oc => oc)
                                       .ToList<object>();
           return query7;
        }
        public List<Customers> Query8()
        {
            var query8 = (from customer in context.Customers
                          where customer.Region == "WA"
                          orderby customer.CustomerID
                          select customer).Take(3).ToList();
            return query8;

        }
        public List<Products> Query9()
        {
            var query9 = context.Products.OrderBy(p => p.ProductName).ToList();
            return query9;
        }
        public List<Products> Query10()
        {
            var query10 = (from product in context.Products
                           orderby product.UnitsInStock descending
                           select product).ToList();
            return query10;

        }
        public List<string> Query11()
        {
            var query11 = context.Categories.Join(context.Products,
                                                   c => c.CategoryID,
                                                   p => p.CategoryID,
                                                   (c, p) => new { categories = c, products = p })
                                            .Select(cp => cp.categories.CategoryName)
                                            .ToList();
            return query11;
        }
        public Products Query12()
        {
            var query12 = (from product in context.Products
                           select product).FirstOrDefault();
            return query12;
        }
        public List<object> Query13()
        {

            var query13 = (from customer in context.Customers
                           join order in context.Orders
                           on customer.CustomerID equals order.CustomerID
                           group customer by customer.CustomerID into orderPerCustomer
                           select new
                           {
                               customerID = orderPerCustomer.Key,
                               customerName = orderPerCustomer.Select(x => x.ContactName).First(),
                               count = orderPerCustomer.Count()
                           }
                          ).ToList<object>();
            return query13;
        }    
    }
}
