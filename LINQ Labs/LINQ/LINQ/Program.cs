using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;

namespace LINQ
{
    internal class Program
    {
        /* Practice your LINQ!
         * You can use the methods in Data Loader to load products, customers, and some sample numbers
         * 
         * NumbersA, NumbersB, and NumbersC contain some ints
         * 
         * The product data is flat, with just product information
         * 
         * The customer data is hierarchical as customers have zero to many orders
         */

        private static void Main()
        {
            Console.Write("Enter a method number to run : ");
            string strEntry = Console.ReadLine();

            switch (strEntry)
            {
                case "1":
                    PrintOutOfStock();
                    break;

                case "2":
                    InStockMoreThan3();
                    break;

                case "3":
                    CustomersInWashington();
                    break;

                case "4":
                    PrintProductNames();
                    break;

                case "5":
                    RaisePrices25();
                    break;

                case "6":
                    PrintProductNamesInUpper();
                    break;

                case "7":
                    EvenNumberInStock();
                    break;

                case "8":
                    RenameSequence();
                    break;

                case "9":
                    BLessThanC();
                    break;

                case "10":
                    TotalLessThan500();
                    break;

                case "11":
                    First3FromA();
                    break;

                case "12":
                    First3CustomersFromWA();
                    break;

                case "13":
                    SkipFirst3FromA();
                    break;

                case "14":
                    Skip2OrdersFromWA();
                    break;

                case "15":
                    ListCUntilGreaterThan6();
                    break;

                case "16":
                    ListCUntilLessThanIndex();
                    break;

                case "17":
                    ListCDivisibleBy3();
                    break;

                case "18":
                    ProductsAlphabetically();
                    break;

                case "19":
                    ProductsInStockDescending();
                    break;

                case "20":
                    ProductsByCategoryThenPriceDescending();
                    break;

                case "21":
                    ReverseC();
                    break;

                case "22":
                    DisplayCGroupedByRemainder();
                    break;

                case "23":
                    GroupProductsByCategory();
                    break;

                case "24":
                    GroupOrdersByYear();
                    break;

                case "25":
                    UniqueCategories();
                    break;

                case "26":
                    UniqueNumbers();
                    break;

                case "27":
                    SharedNumbers();
                    break;

                case "28":
                    UniqueFromA();
                    break;

                case "29":
                    FirstProductWithID12();
                    break;

                case "30":
                    Does789Exist();
                    break;

                case "31":
                    CategoriesWithOneOutOfStock();
                    break;

                case "32":
                    BLessThan9();
                    break;

                case "33":
                    AllProductsInCategoryInStock();
                    break;

                case "34":
                    NumberofOddsInA();
                    break;

                case "35":
                    CustomerIDsAndOrders();
                    break;

                case "36":
                    NumberofProductsByCategory();
                    break;

                case "37":
                    DisplayTotalInStockPerCategory();
                    break;

                case "38":
                    DisplayLowestPricedPerCategory();
                    break;

                case "39":
                    DisplayHighestPricedPerCategory();
                    break;

                case "40":
                    DisplayAveragePricePerCategory();
                    break;

            }

            Console.ReadLine();
        }

        //1. Find all products that are out of stock.
        private static void PrintOutOfStock()
        {
            var products = DataLoader.LoadProducts();

            //var results = products.Where(p => p.UnitsInStock == 0);
            var results = from p in products
                where p.UnitsInStock == 0
                select p;

            foreach (var product in results)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        //2. Find all products that are in stock and cost more than 3.00 per unit.
        private static void InStockMoreThan3()
        {
            var products = DataLoader.LoadProducts();

            //var results = products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);
            var results = from p in products
                where p.UnitsInStock > 0 && p.UnitPrice > 3
                select p;

            foreach (var product in results)
            {
                Console.WriteLine("{0} has {1} in stock with unit price {2}", product.ProductName,
                    product.UnitsInStock, product.UnitPrice);
            }
        }

        //3. Find all customers in Washington, print their name then their orders. (Region == "WA")
        private static void CustomersInWashington()
        {
            var customers = DataLoader.LoadCustomers();
            var products = DataLoader.LoadProducts();

            var results = from c in customers
                where c.Region == "WA"
                select c;

            foreach (var customer in results)
            {
                Console.WriteLine("\n{0} is in WA and ordered :", customer.CompanyName);

                for (int i = 0; i < customer.Orders.Length; i++)
                {
                    var order = customer.Orders[i];
                    Console.WriteLine("\n\tOrder ID: {0}\n\tOrder Date: {1}\n\tOrder Total: {2}", order.OrderID,
                        order.OrderDate, order.Total);
                }
            }
        }

        //4. Create a new sequence with just the names of the products.
        private static void PrintProductNames()
        {
            var products = DataLoader.LoadProducts();

            //var results = products.Where(p => p.ProductName != string.Empty);

            var results = from p in products
                where p.ProductName != string.Empty
                select p;

            foreach (var product in results)
            {
                Console.WriteLine("{0}", product.ProductName);
            }
        }

        //5. Create a new sequence of products and unit prices where the unit prices are increased by 25%.
        private static void RaisePrices25()
        {
            var products = DataLoader.LoadProducts();

            //var results = products.Where(p => p.ProductName != string.Empty);

            var results = from p in products
                where p.ProductName != string.Empty
                select p;

            foreach (var product in results)
            {
                Console.WriteLine("{0} has a new price of {1}", product.ProductName,
                    decimal.Multiply(product.UnitPrice, (decimal) 1.25));
            }
        }

        //6. Create a new sequence of just product names in all upper case.
        private static void PrintProductNamesInUpper()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                where p.ProductName != string.Empty
                select p;

            foreach (var product in products)
            {
                Console.WriteLine("{0}", product.ProductName.ToUpper());
            }
        }

        //7. Create a new sequence with products with even numbers of units in stock.
        private static void EvenNumberInStock()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                where (p.UnitsInStock%2 == 0)
                select p;

            foreach (var product in results)
            {
                Console.WriteLine("{0} has an even number of units in stock", product.ProductName);
            }
        }

        //8. Create a new sequence of products with ProductName, Category, and rename UnitPrice to Price.
        private static void RenameSequence()
        {
            var products = DataLoader.LoadProducts();

            /*var results =
                products.Where(p => p.ProductName != string.Empty)
                    .Select(p => new { Price = p.UnitPrice, ProductName = p.ProductName, Category = p.Category });*/

            var results = from p in products
                where p.ProductName != string.Empty
                select new {Price = p.UnitPrice, ProductName = p.ProductName, Category = p.Category};

            foreach (var result in results)
            {
                Console.WriteLine("Product Name: {0}\nCategory: {1}\nPrice: {2}\n", result.ProductName, result.Category,
                    result.Price);
            }
        }

        //9. Make a query that returns all pairs of numbers from both arrays such that the number from numbersB is less than the number from numbersC.
        private static void BLessThanC()
        {
            var numbersB = DataLoader.NumbersB;
            var numbersC = DataLoader.NumbersC;

            var results = from b in numbersB
                from c in numbersC
                where b < c
                select new {b, c};

            foreach (var x in results)
            {
                Console.WriteLine("{0}", x);
            }

        }

        //10. Select CustomerID, OrderID, and Total where the order total is less than 500.00.
        private static void TotalLessThan500()
        {
            var customers = DataLoader.LoadCustomers();

            var results = from c in customers
                from o in c.Orders
                where o.Total < 500
                select new {c.CustomerID, o.OrderID, o.Total};

            foreach (var result in results)
            {
                Console.WriteLine("Customer ID: {0}\nOrder ID: {1}\nTotal: {2}\n", result.CustomerID, result.OrderID,
                    result.Total);
            }
        }

        //11. Write a query to take only the first 3 elements from NumbersA.
        private static void First3FromA()
        {
            var numbersA = DataLoader.NumbersA;

            var results = (from i in numbersA
                orderby i ascending
                select i).Take(3);

            foreach (var result in results)
            {
                Console.WriteLine("{0}", result);
            }
        }

        //12. Get only the first 3 orders from customers in Washington.
        private static void First3CustomersFromWA()
        {
            var customers = DataLoader.LoadCustomers();
            //var products = DataLoader.LoadProducts();

            var results = (from c in customers
                from o in c.Orders
                where c.Region == "WA"
                orderby o.OrderDate ascending
                select new {c.CompanyName, o.OrderID, o.OrderDate, o.Total}).Take(3);

            Console.WriteLine("\nThe first three orders from Washington are:\n");

            foreach (var result in results)
            {
                Console.WriteLine("Company : {0}\nOrdered on : {1}\nOrderID : {2}\n", result.CompanyName,
                    result.OrderDate, result.OrderID);
            }
        }

        //13. Skip the first 3 elements of NumbersA.
        private static void SkipFirst3FromA()
        {
            var numbersA = DataLoader.NumbersA;

            var results = (from i in numbersA
                orderby i ascending
                select i).Skip(3);

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }

        }

        //14. Get all except the first two orders from customers in Washington.
        private static void Skip2OrdersFromWA()
        {
            var customers = DataLoader.LoadCustomers();

            var results = (from c in customers
                where c.Region == "WA"
                from o in c.Orders
                orderby o.OrderDate ascending
                select new {c.CompanyName, o.OrderDate, o.OrderID}).Skip(2);

            foreach (var result in results)
            {
                Console.WriteLine("Company Name : {0}\nOrdered on : {1}\nOrderID : {2}\n", result.CompanyName,
                    result.OrderDate, result.OrderID);
            }
        }

        //15. Get all the elements in NumbersC from the beginning until an element is greater or equal to 6.
        private static void ListCUntilGreaterThan6()
        {
            var numbersC = DataLoader.NumbersC;

            var numberslessthansix = numbersC.TakeWhile(n => n < 6);

            foreach (var x in numberslessthansix)
            {
                Console.WriteLine(x);
            }
        }

        //16. Return elements starting from the beginning of NumbersC until a number is hit that is less than its position in the array.
        private static void ListCUntilLessThanIndex()
        {
            var numbersC = DataLoader.NumbersC;

            var numberslessthanindex = numbersC.TakeWhile((n, index) => n >= index);

            foreach (var x in numberslessthanindex)
            {
                Console.WriteLine(x);
            }
        }

        //17. Return elements from NumbersC starting from the first element divisible by 3.
        private static void ListCDivisibleBy3()
        {
            var numbersC = DataLoader.NumbersC;

            var numbersdivi3 = numbersC.SkipWhile(n => n%3 != 0);

            foreach (var x in numbersdivi3)
            {
                Console.WriteLine(x);
            }
        }

        //18. Order products alphabetically by name.
        private static void ProductsAlphabetically()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                orderby p.ProductName
                select p;

            foreach (var product in results)
            {
                Console.WriteLine("Product Name : {0}, ID : {1}",product.ProductName, product.ProductID);
            }
        }

        //19. Order products by UnitsInStock descending.
        private static void ProductsInStockDescending()
        {
            var products = DataLoader.LoadProducts();

            var results = products.OrderByDescending(product => product.UnitsInStock).ToList();

            foreach (var product in results)
            {
                Console.WriteLine("Product name : {0}\nUnits in stock : {1}\nID : {2}\n",product.ProductName, product.UnitsInStock, product.ProductID);
            }
        }

        //20.Sort the list of products, first by category, and then by unit price, from highest to lowest.
        private static void ProductsByCategoryThenPriceDescending()
        {
            var products = DataLoader.LoadProducts();

            //var results = products.GroupBy(p => p.Category).Select(pCats => new {Category = pCats.Key, Product = pCats});
            var results = from p in products
                orderby p.Category, p.UnitPrice descending
                group p by p.Category
                into pCats
                select new {Category = pCats.Key, Product = pCats};

            foreach (var result in results)
            {
                Console.WriteLine("{0}", result.Category);
                for (int i = 0; i < result.Product.Count(); i++)
                {
                    Console.WriteLine("\t{0} - {1:c}", result.Product.ElementAt(i).ProductName, result.Product.ElementAt(i).UnitPrice);
                }
            }
        }

        //21.Reverse NumbersC.
        private static void ReverseC()
        {
            var numbersC = DataLoader.NumbersC;

            var results = (from i in numbersC
                select i).Reverse();

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }

        }

        //22.Display the elements of NumbersC grouped by their remainder when divided by 5.
        private static void DisplayCGroupedByRemainder()
        {
            var numbersC = DataLoader.NumbersC;

            var results = from i in numbersC
                group i by i%5
                into c
                select new {Remainder = c.Key, Numbers = c};

            foreach (var c in results)
            {
                Console.WriteLine("Numbers with a remainder of {0} when divided by 5", c.Remainder);
                foreach (var n in c.Numbers)
                {
                    Console.WriteLine(n);
                }
            }
        }

        //23.Display products by Category.
        private static void GroupProductsByCategory()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                group p by p.Category
                into pCats
                select new {pCats.Key, coll = pCats};

            foreach (var result in results)
            {
                Console.WriteLine("{0}", result.Key);
                foreach (var product in result.coll)
                {
                    Console.WriteLine("\t{0} - {1:c}", product.ProductName, product.UnitPrice);
                }
            }

        }

        //24. Group customer orders by year, then by month.
        private static void GroupOrdersByYear()
        {
            var customers = DataLoader.LoadCustomers();

            var results = from c in customers
                select new
                {
                    YearGroups = from o in c.Orders
                        group o by o.OrderDate.Year
                        into yg
                        select new
                        {
                            Year = yg.Key,
                            MonthGroup = from o in yg
                                group o by o.OrderDate.Month
                                into mg
                                select new
                                {
                                    Month = mg.Key,
                                    Orders = mg
                                }
                        }
                };

            foreach (var result in results)
            {
                for (int i = 0; i < result.YearGroups.Count(); i++)
                {
                    Console.WriteLine("{0}",result.YearGroups.ElementAt(i).Year);
                    for (int j = 0; j < result.YearGroups.ElementAt(i).MonthGroup.Count(); j++)
                    {
                        Console.WriteLine("\t{0}", result.YearGroups.ElementAt(i).MonthGroup.ElementAt(j).Month);
                        for (int k = 0; k < result.YearGroups.ElementAt(i).MonthGroup.ElementAt(j).Orders.Count(); k++)
                        {
                            Console.WriteLine("\t\tOrder ID : {0}", result.YearGroups.ElementAt(i).MonthGroup.ElementAt(j).Orders.ElementAt(k).OrderID);
                        }
                    }
                }
            }
        }

        //25.Create a list of unique product category names.
        private static void UniqueCategories()
        {
            var products = DataLoader.LoadProducts();

            var results = (from p in products
                select p.Category).Distinct();

            foreach (var result in results)
            {
                Console.WriteLine("\"{0}\" is a unique category name\n", result);
            }
        }

        //26.Get a list of unique values from NumbersA and NumbersB.
        private static void UniqueNumbers()
        {
            var numbersA = DataLoader.NumbersA;
            var numbersB = DataLoader.NumbersB;

            var uniquenumbers = numbersA.Union(numbersB);

            Console.WriteLine("Unique numbers from A and B : ");
            foreach (var n in uniquenumbers)
            {
                Console.WriteLine(n);
            }
        }

        //27.Get a list of the shared values from NumbersA and NumbersB.
        private static void SharedNumbers()
        {
            var numbersA = DataLoader.NumbersA;
            var numbersB = DataLoader.NumbersB;

            var sharednumbers = numbersA.Intersect(numbersB);

            Console.WriteLine("Shared numbers from A and B : ");
            foreach (var n in sharednumbers)
            {
                Console.WriteLine(n);
            }
        }

        //28.Get a list of values in NumbersA that are not also in NumbersB.
        private static void UniqueFromA()
        {
            var numbersA = DataLoader.NumbersA;
            var numbersB = DataLoader.NumbersB;

            var aOnlyNumbers = numbersA.Except(numbersB);

            Console.WriteLine("Numbers in A but not B : ");
            foreach (var n in aOnlyNumbers)
            {
                Console.WriteLine(n);
            }
        }

        //29.Select only the first product with ProductID = 12 (not a list).
        private static void FirstProductWithID12()
        {
            var products = DataLoader.LoadProducts();

            var result = (from p in products
                where p.ProductID == 12
                select p).First();

            Console.WriteLine("Product name : {0}\nCost : {1}\nUnits in stock : {2}\nID : {3}", result.ProductName, result.UnitPrice, result.UnitsInStock, result.ProductID);
        }

        //30. Write code to check if ProductID 789 exists.
        private static void Does789Exist()
        {
            var products = DataLoader.LoadProducts();

            var prod789 = (from p in products
                where p.ProductID == 789
                select p).FirstOrDefault();

            Console.WriteLine("789 Exists? {0}", prod789 != null);
        }

        //31. Get a list of categories that have at least one product out of stock.
        private static void CategoriesWithOneOutOfStock()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                group p by p.Category
                into pCats
                where pCats.Any(x => x.UnitsInStock == 0)
                select new {Categories = pCats.Key, Products = pCats};

            foreach (var result in results)
            {
                Console.WriteLine("{0}", result.Categories);
                for (int i = 0; i < result.Products.Count(); i++)
                {
                    Console.WriteLine("\t{0} - {1}", result.Products.ElementAt(i).ProductName, result.Products.ElementAt(i).UnitsInStock);
                }
            }
        }

        //32. Determine if NumbersB contains only numbers less than 9.
        private static void BLessThan9()
        {
            var numbersB = DataLoader.NumbersB;

            bool lessThan9 = numbersB.All(x => x < 9);

            Console.WriteLine("Numbers B only contains numbers less than 9 : {0}", lessThan9);
        }

        //33. Get a grouped a list of products only for categories that have all of their products in stock.
        private static void AllProductsInCategoryInStock()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                group p by p.Category
                into pCats
                where pCats.All(x => x.UnitsInStock > 0)
                select new {Categories = pCats.Key, Products = pCats};

            foreach (var result in results)
            {
                Console.WriteLine("{0}", result.Categories);
                for (int i = 0; i < result.Products.Count(); i++)
                {
                    Console.WriteLine("\t{0} - {1}", result.Products.ElementAt(i).ProductName, result.Products.ElementAt(i).UnitsInStock);
                }
            }
        }

        //34. Count the number of odds in NumbersA.
        private static void NumberofOddsInA()
        {
            var numbersA = DataLoader.NumbersA;

            int oddNumbers = numbersA.Count(n => n%2 == 1);

            Console.WriteLine("There are {0} odd numbers in A.", oddNumbers);
        }

        //35. Display a list of CustomerIDs and only the count of their orders.
        private static void CustomerIDsAndOrders()
        {
            var customers = DataLoader.LoadCustomers();

            var results = from c in customers
                select new {c.CustomerID, orderCount = c.Orders.Count()};

            foreach (var result in results)
            {
                Console.WriteLine("Customer {0} has {1} orders", result.CustomerID, result.orderCount);
            }
        }

        //36. Display a list of categories and the count of their products.
        private static void NumberofProductsByCategory()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                group p by p.Category
                into pCats
                select new {Category = pCats.Key, ProductCount = pCats.Count()};

            foreach (var result in results)
            {
                Console.WriteLine("Product category {0} has {1} products", result.Category, result.ProductCount);
            }
        }

        //37. Display the total units in stock for each category.
        private static void DisplayTotalInStockPerCategory()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                group p by p.Category
                into pCats
                select new {Category = pCats.Key, Total = pCats.Sum(x => x.UnitsInStock)};

            foreach (var result in results)
            {
                Console.WriteLine("Product Category {0} has {1} units in stock", result.Category, result.Total);
            }
        }

        //38. Display the lowest priced product in each category.
        private static void DisplayLowestPricedPerCategory()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                group p by p.Category
                into pCats
                let minPrice = pCats.Min(x => x.UnitPrice)
                select new {Category = pCats.Key, CheapestProduct = pCats.Where(p => p.UnitPrice == minPrice)};

            foreach (var result in results)
            {
                Console.WriteLine("{0}'s lowest priced product is {1}", result.Category, result.CheapestProduct.ElementAt(0).ProductName);
            }
        }

        //39. Display the highest priced product in each category.
        private static void DisplayHighestPricedPerCategory()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                          group p by p.Category
                into pCats
                          let maxPrice = pCats.Max(x => x.UnitPrice)
                          select new { Category = pCats.Key, ExpensiveProduct = pCats.Where(p => p.UnitPrice == maxPrice) };

            foreach (var result in results)
            {
                Console.WriteLine("{0}'s highest priced product is {1}", result.Category, result.ExpensiveProduct.ElementAt(0).ProductName);
            }
        }

        //40. Show the average price of product for each category.
        private static void DisplayAveragePricePerCategory()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                group p by p.Category
                into pCats
                select new {Category = pCats.Key, AveragePrice = pCats.Average(x => x.UnitPrice)};

            foreach (var result in results)
            {
                Console.WriteLine("{0} have an average price of {1:c}", result.Category, result.AveragePrice);
            }
        }
    }
}
