using System;
using System.Collections.Generic;
using System.Linq;


namespace S_CRM
{
    class Program
    {
        public static List<Product> products = new List<Product>();
        public static List<string> idList = new List<string>();
        static void Main(string[] args)
        {
            /*readFile(@"C:\Users\KCA6\Desktop/products.csv");*/
            var lines = System.IO.File.ReadLines("products.csv");
            var firstCustomer = new Customer("ZISOULI")
            {
                CustomerId = 15
            };
            var secondCustomer = new Customer("EVA")
            {
                CustomerId = 45
            };
            var firstOrder = new Order();
            var secondOrder = new Order();
            for (var i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"product Id is   {products[i].ProductId} " +
                    $" description is    {products[i].Description}" +
                    $" price is  {products[i].Price} ");
            }
            decimal summaryFirst = 0;
            decimal summarySecond = 0;
            firstOrder.ProductList = (CustomerProductListGenerate(products));
            foreach (Product X in firstOrder.ProductList)
            {
                firstOrder.TotalAmount =+ X.Price;
            }
            Console.WriteLine(firstOrder.TotalAmount);
            
            if (summaryFirst == null || summarySecond == null)
            {
                throw new ArgumentNullException();
            }
            if (summaryFirst > summarySecond)
            {
                Console.WriteLine($"The {firstCustomer}make a bigger order");
            } else if (summarySecond > summaryFirst)
            {
                Console.WriteLine($"The {secondCustomer}make a biger order");
            } else
                Console.WriteLine("no order");
        }
    }
    
    /*public static void readFile(string file)
    {
        if (file == null)
        {
            throw new ArgumentNullException();
        }
        using (var read = File.OpenText(file))
        {
            while (!read.EndOfStream)
            {
                var line = read.ReadLine();
                var words = line.Split(';');
                var productEntry = new Product();
                var price = RandomNum();
                idList.Add(words[0]);
                if (!checkId(idList, words[0]))
                {
                    productEntry.Price = price;
                    productEntry.ProductId = words[0];
                    productEntry.Description = words[1];
                    products.Add(productEntry);
                }
            }
        }
    }*/
    
    public static decimal RandomNum()
    {
        Random value = new Random();
        var randomNum = value.NextDouble() + value.Next(1, 1000);
        var randomNum2 = randomNum.ToString("0.00");
        var timi = System.Convert.ToDecimal(randomNum2);
        if (timi == 0)
        {
            throw new ArgumentNullException();
        }
        return timi;
    }
    public static List<Product> CustomerProductListGenerate(List<Product> productList)
    {
        var CustomerProductList = new List<Product>();
        Random r = new Random();
        for (var i = 0; i < 10; i++)
        {
            var randomIndex = r.Next(0, productList.Count);
            CustomerProductList.Add(productList[randomIndex]);
        }
        return CustomerProductList;
    }
    public static bool CheckId(List<string> list, string id)
    {
        if (list == null || id == null)
        {
            throw new ArgumentNullException();
        }
        if (!string.IsNullOrWhiteSpace(id))
        {
            list.SingleOrDefault(s => s.Equals(id));
            return false;
        } else
        {
            throw new Exception("Id not unique");
        }
    }
}
