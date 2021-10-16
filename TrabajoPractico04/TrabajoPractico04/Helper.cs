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
        //public static IBaseLogic<Customers> customerDb = new CustomersLogic();
        //public static IBaseLogic<Categories> categoryDb = new CategoriesLogic();
        public static void ExecuteMenu(string menuOption)
        {
            switch (menuOption.ToUpper())
            {
                case "AA":
                    Console.Clear();
                    Console.WriteLine("Please, add the new customer information:");
                    try
                    {
                        customerDb.Add(ShowCustomerMenu());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("There was an error with the input. Please, make sure you are typing the information correctly.");
                    }
                    break;
                case "AB":
                    Console.Clear();
                    Console.WriteLine("Please, add the new category information:");
                    try
                    {
                        categoryDb.Add(ShowCategoryMenu());
                    }
                    catch
                    {
                        Console.WriteLine("There was an error with the input. Please, make sure you are typing the information correctly.");
                    }
                    break;
                case "BA":
                    bool repit = false;

                    do
                    {
                        try
                        {
                            customerDb.Update(ShowUpdateCustomerMenu());
                            repit = true;
                        }
                        catch
                        {
                            Console.WriteLine("Something went worng, make sure you are inserting the ID correctly.");
                            repit = true;
                        }
                    } while (!repit);
                    break;
                case "BB":
                    repit = false;
                    do
                    {
                        try
                        {
                            categoryDb.Update(ShowUpdateCategoryMenu());
                            repit = true;
                        }
                        catch
                        {
                            Console.WriteLine("Something went worng, make sure you are inserting the ID correctly.");
                            repit = true;
                        }

                    } while (!repit);
                    break;
                case "CA":
                    repit = false;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Please insert the ID of the customer information you want to delete: ");
                        try
                        {
                            customerDb.Delete(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Oops, the customer you are tryig to delete does not exists.");
                            Console.WriteLine("Do you want to try again? Y - N");
                            if (Console.ReadLine().ToUpper() != "N")
                            {
                                repit = true;
                            }
                        }
                    }
                    while (!repit);
                    break;
                case "CB":
                    repit = false;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Please insert the ID of the category information you want to delete: ");
                        try
                        {
                            categoryDb.Delete(Convert.ToInt32(Console.ReadLine()));

                        }
                        catch
                        {
                            Console.WriteLine("Oops, the category you are tryig to delete does not exists.");
                            Console.WriteLine("Do you want to try again? Y - N");
                            if (Console.ReadLine().ToUpper() != "N")
                            {
                                repit = true;
                            }
                        }

                    } while (!repit);
                    break;
                case "DA":
                    repit = false;
                    do
                    {
                        Console.WriteLine("If you know the ID of the customer you want to retrieve information, press 1:");
                        Console.WriteLine("If you want to retrieve information of all customers, press 2:");
                        int optionCustomerRetriveInfo = Convert.ToInt32(Console.ReadLine());
                        if (optionCustomerRetriveInfo == 1)
                        {
                            Console.WriteLine("Please insert the customer ID: ");
                            Customers customerToShow = customerDb.GetById(Console.ReadLine());
                            Console.WriteLine($"Customer ID: {customerToShow.CustomerID}");
                            Console.WriteLine($"Company Name: {customerToShow.CompanyName}");
                            Console.WriteLine($"Contact Name ID: {customerToShow.ContactName}");
                            Console.WriteLine($"Contact title: {customerToShow.ContactTitle}");
                            Console.WriteLine($"City: {customerToShow.City}");
                            Console.WriteLine($"Country: {customerToShow.Country}");
                            Console.WriteLine($"Address: {customerToShow.Address}");
                            Console.WriteLine($"Customer ID: {customerToShow.Phone}");
                            Console.WriteLine($"Postal Code: {customerToShow.PostalCode}");
                            Console.WriteLine($"fax: {customerToShow.Fax}");
                            Console.WriteLine("");
                            Console.WriteLine("Press any key to exit.");
                            Console.ReadKey();
                            repit = true;
                        }
                        else if (optionCustomerRetriveInfo == 2)
                        {
                            foreach (var item in customerDb.GetAll())
                            {
                                Console.WriteLine($"Customer ID: {item.CustomerID}");
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
                                Console.WriteLine("Press any key to exit.");
                                Console.ReadKey();
                                Console.WriteLine("Press any key to exit.");
                                Console.ReadKey();
                                repit = true;

                            }
                        }
                        else
                        {
                            Console.WriteLine("You have entered an invalid option, please try again. press any key to continue.");
                            Console.ReadKey();
                            repit = true;
                        }
                    } while (!repit);
                    break;
                case "DB":
                    repit = false;
                    do
                    {
                        Console.WriteLine("If you know the ID of the category you want to retrieve information, press 1:");
                        Console.WriteLine("If you want to retrieve information of all categories press 2:");
                        int optionCategoryRetriveInfo = Convert.ToInt32(Console.ReadLine());
                        if (optionCategoryRetriveInfo == 1)
                        {
                            Console.WriteLine("Please insert the category ID: ");
                            Categories categryToShow = categoryDb.GetById(Convert.ToInt32(Console.ReadLine()));
                            Console.WriteLine($"Customer ID: {categryToShow.CategoryID}");
                            Console.WriteLine($"Category name: {categryToShow.CategoryName}");
                            Console.WriteLine($"Description: {categryToShow.Description}");
                            Console.WriteLine($"Picture: {categryToShow.Picture}");
                            Console.WriteLine("");
                            Console.WriteLine("Press any key to exit.");
                            Console.ReadKey();
                            repit = true;
                        }
                        else if (optionCategoryRetriveInfo == 2)
                        {
                            foreach (var item in categoryDb.GetAll())
                            {
                                Console.WriteLine($"Category ID: {item.CategoryID}");
                                Console.WriteLine($"Company Name: {item.CategoryName}");
                                Console.WriteLine($"Description: {item.Description}");
                                Console.WriteLine($"picture: {item.Picture}");
                                Console.WriteLine("");
                                repit = true;

                            }
                            Console.WriteLine("Press any key to exit.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("You have entered an invalid option, please try again. press any key to continue.");
                            Console.ReadKey();
                            repit = true;
                        }
                    } while (!repit);
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
            bool repit = false;
            do
            {
                Customers customerToUpdate = new Customers { };
                Console.WriteLine("Please enter the ID of the customer you want to update: ");
                String saveChanges = "";
                customerToUpdate = customerDb.GetById(Console.ReadLine());
                if (customerToUpdate == null)
                {
                    Console.WriteLine("Oops, the customer you are looking for does not exists.");
                    Console.WriteLine("Do you want to try again? Y - N");
                    if (Console.ReadLine().ToUpper() == "N")
                    {
                        repit = true;
                    }
                }
                else
                {
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
                }
                return customerToUpdate;
            } while (!repit);
        }

        public static Categories ShowUpdateCategoryMenu()
        {
            bool repit = false;
            do
            {
                Categories categoryToUpdate = new Categories { };
                Console.WriteLine("Please enter the ID of the category you want to update: ");
                String saveChanges = "";
                categoryToUpdate = categoryDb.GetById(Convert.ToInt32(Console.ReadLine()));
                if (categoryToUpdate == null)
                {
                    Console.WriteLine("Oops, the category you are looking for does not exists.");
                    Console.WriteLine("Do you want to try again? Y - N");
                    if (Console.ReadLine().ToUpper() == "N")
                    {
                        repit = true;
                    }
                }
                else
                {
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
                    } while (saveChanges.ToUpper() == "N");
                }
                return categoryToUpdate;
            } while (!repit);
        }

    }
}
