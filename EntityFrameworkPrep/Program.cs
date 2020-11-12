using EntityFrameworkPrep.Data;
using EntityFrameworkPrep.Models;
using System;
using System.Linq;

namespace EntityFrameworkPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            using EntityFrameworkPrepContext context = new EntityFrameworkPrepContext();


            //Adding new entries to the database
            /*
            Product MagikarpPromo = new Product()
            {
                Name = "Magikarp Card",
                Price = 4.99M
            };
            context.Products.Add(MagikarpPromo);

            Product PonytaPromo = new Product()
            {
                Name = "Ponyta Card",
                Price = 2.99M
            };
            context.Products.Add(PonytaPromo);
            context.SaveChanges();
            */


            //Quering the database
            
            //Query using fluent API 
            var products = context.Products
                .Where(p => p.Price >= 3.00m)
                .OrderBy(p => p.Name);
            /*
            //LINQ equivelant
            var products = from product in context.Products
                           where product.Price > 3.00m
                           orderby product.Name
                           select product;
            */


            //Updating the database
            /*
            var magikarpCard = context.Products
                                .Where(p => p.Name == "Magikarp Card")
                                .FirstOrDefault();
            if (magikarpCard is Product) //checking that its not null
            {
                magikarpCard.Price = 12.99m;
                //To DELETE: context.Remove(magicarpCard); 
            }
            context.SaveChanges();
            */



            //Printing list of products
            Console.WriteLine("Products with price above 3.00:");
            foreach (Product p in products)
            {
                Console.WriteLine($"Id:    {p.Id}");
                Console.WriteLine($"Name:  {p.Name}");
                Console.WriteLine($"Price: {p.Price}");
                Console.WriteLine(new string('-', 20));
            }
            
        }
    }
}
