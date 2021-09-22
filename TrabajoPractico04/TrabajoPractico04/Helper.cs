using System;
using System.Text;
using TrabajoPractico04.DATA;
using TrabajoPractico04.ENTITIES;

namespace TrabajoPractico04.LOGIC
{
    public class Helper
    {

        public static CustomersLogic customerDb = new CustomersLogic();
        public static CategoriesLogic categoryDb = new CategoriesLogic();
        public static void ExecuteMenu(string menuOption)
        {
           switch (menuOption.ToUpper())
            {
                case "AA":
                    Console.Clear();
                    Console.WriteLine("Please, add the new customer information:");
                    customerDb.Add(ShowCustomerMenu());
                    break;
                case "AB":
                    Console.Clear();
                    Console.WriteLine("Please, add the new category information:");
                   categoryDb.Add(ShowCategoryMenu());
                    break;
                case "BA":
                    customerDb.Update(ShowUpdateCustomerMenu());
                    break;
                case "BB":
                    categoryDb.Update(ShowUpdateCategoryMenu());
                    break;
                case "CA":
                    Console.Clear();
                    Console.WriteLine("Please insert the ID of the customer information you want to delete: ");
                    customerDb.Delete(Console.ReadLine());
                    break;
                case "CB":
                    Console.Clear();
                    Console.WriteLine("Please insert the ID of the category information you want to delete: ");
                    categoryDb.Delete(Convert.ToInt32(Console.ReadLine()));
                    break;
                case "DA":
                    foreach (var item in customerDb.Getall())
                    {
                        Console.WriteLine($"Customer ID: {item.CustomerID} /n");
                        Console.WriteLine($"Company Name: {item.CompanyName}");
                        Console.WriteLine($"Contact Name ID: {item.ContactName}");
                        Console.WriteLine($"Contact title: {item.ContactTitle}");
                        Console.WriteLine($"City: {item.City}");
                        Console.WriteLine($"Country: {item.Country}");
                        Console.WriteLine($"Address: {item.Address}");
                        Console.WriteLine($"Customer ID: {item.Phone}");
                        Console.WriteLine($"Postal Code: {item.PostalCode}");
                        Console.WriteLine($"fax: {item.Fax}");
                        Console.WriteLine("");

                    }
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();
                    break;
                case "DB":
                   foreach (var item in categoryDb.Getall())
                    {
                        Console.WriteLine($"Customer ID: {item.CategoryID}");
                        Console.WriteLine($"Company Name: {item.CategoryName}");
                        Console.WriteLine($"Contact Name ID: {item.Description}");
                        Console.WriteLine($"Contact title: {item.Picture}");
                        Console.WriteLine("");
                        
                    }
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();
                    break;
            }
        }

        public static Customers ShowCustomerMenu()
        {

            Customers customer = new Customers();
            string saveChanges = "";
            do
            {
                Console.WriteLine("Customer ID: ");
                customer.CustomerID = Console.ReadLine();
                Console.WriteLine("Company Name: ");
                customer.CompanyName = Console.ReadLine();
                Console.WriteLine("Contact Name: ");
                customer.ContactName = Console.ReadLine();
                Console.WriteLine("Contact Title: ");
                customer.ContactTitle = Console.ReadLine();
                Console.WriteLine("Address: ");
                customer.Address = Console.ReadLine();
                Console.WriteLine("City: ");
                customer.City = Console.ReadLine();
                Console.WriteLine("Region: ");
                customer.Region = Console.ReadLine();
                Console.WriteLine("Postal Code: ");
                customer.PostalCode = Console.ReadLine();
                Console.WriteLine("Country: ");
                customer.Country = Console.ReadLine();
                Console.WriteLine("Phone: ");
                customer.Phone = Console.ReadLine();
                Console.WriteLine("Fax: ");
                customer.Fax = Console.ReadLine();

                Console.WriteLine("Save changes? Y - N ");
                saveChanges = Console.ReadLine();

            } while (saveChanges.ToUpper() != "Y");

            return customer;
        }
        public static Categories ShowCategoryMenu()
        {
            Categories category = new Categories();
            string saveChanges = "";
            do
            {                
                Console.WriteLine("Category Name: ");
                category.CategoryName = Console.ReadLine();
                Console.WriteLine("Description: ");
                category.Description = Console.ReadLine();
                Console.WriteLine("Picture: ");
                category.Picture = Encoding.ASCII.GetBytes(Console.ReadLine());

                Console.WriteLine("Save changes? Y - N ");
                saveChanges = Console.ReadLine();

            } while (saveChanges.ToUpper() != "Y");

            return category;
        }
        public static Customers ShowUpdateCustomerMenu()
        {
            bool exit = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Please enter the ID of the customer you want to update: ");
                var customerToUpdate = customerDb.GetById(Console.ReadLine());
                if (customerToUpdate != null)
                {
                    String saveChanges = "";
                    do
                    {
                        Console.WriteLine("Company Name: ");
                        customerToUpdate.CompanyName = Console.ReadLine();
                        Console.WriteLine("Contact Name: ");
                        customerToUpdate.ContactName = Console.ReadLine();
                        Console.WriteLine("Contact Title: ");
                        customerToUpdate.ContactTitle = Console.ReadLine();
                        Console.WriteLine("Address: ");
                        customerToUpdate.Address = Console.ReadLine();
                        Console.WriteLine("City: ");
                        customerToUpdate.City = Console.ReadLine();
                        Console.WriteLine("Region: ");
                        customerToUpdate.Region = Console.ReadLine();
                        Console.WriteLine("Postal Code: ");
                        customerToUpdate.PostalCode = Console.ReadLine();
                        Console.WriteLine("Country: ");
                        customerToUpdate.Country = Console.ReadLine();
                        Console.WriteLine("Phone: ");
                        customerToUpdate.Phone = Console.ReadLine();
                        Console.WriteLine("Fax: ");
                        customerToUpdate.Fax = Console.ReadLine();

                        Console.WriteLine("Save changes? Y - N ");
                        saveChanges = Console.ReadLine();
                    } while (saveChanges.ToUpper() != "Y");
                    return customerToUpdate;
                }
                else
                {
                    Console.WriteLine("Oops, the customer you are looking for does not exists.");
                    Console.WriteLine("Do you want to try again? Y - N");
                    if (Console.ReadLine().ToUpper() != "N")
                    {
                        exit = true;
                    }
                }
            } while (exit == false);
            return null;

        }
        public static Categories ShowUpdateCategoryMenu()
        {
            bool exit = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Please enter the ID of the category you want to update: ");
                var categoryToUpdate = categoryDb.GetById(Convert.ToInt32(Console.ReadLine()));
                if (categoryToUpdate != null)
                {
                    String saveChanges = "";
                    do
                    {
                        Console.WriteLine("Category Name: ");
                        categoryToUpdate.CategoryName = Console.ReadLine();
                        Console.WriteLine("Description: ");
                        categoryToUpdate.Description = Console.ReadLine();
                        Console.WriteLine("Picture: ");
                        categoryToUpdate.Picture = Encoding.ASCII.GetBytes(Console.ReadLine());

                        Console.WriteLine("Save changes? Y - N ");
                        saveChanges = Console.ReadLine();
                    } while (saveChanges.ToUpper() != "N");
                    return categoryToUpdate;
                }
                else
                {
                    Console.WriteLine("Oops, the category you are looking for does not exists.");
                    Console.WriteLine("Do you want to try again? Y - N");
                    if (Console.ReadLine().ToUpper() != "N")
                    {
                        exit = true;
                    }
                }
            } while (exit == false);
            return null;

        }

    }
}
