using System;
using System.Linq;
using ASP4.Extensions;


    namespace ASP4.Models
{
    public static class ProductSeed
    {
        public static void InitData(ProductContext context)
        {
            var rnd = new Random();

            var adjectives = new[] { "Smart", "Economic", "Good", "Intelligient", "Bad" };
            var materials = new[] { "Componise", "Traditional", "Fake", "Plastic", "Copper", "Obident" };
            var names = new[] { "Thresa", "Dina", "Catherine", "Bridget", "Precious" };
            var departments = new[] { "Kuomboka", "Roma", "Hellen", "Ghana", "Mazabuka" };

            context.Products.AddRange(900.Times(x =>
            {
                var adjective = adjectives[rnd.Next(0, 5)];
                var material = materials[rnd.Next(0, 5)];
                var name = names[rnd.Next(0, 5)];
                var department = departments[rnd.Next(0, 5)];
                var productId = $"{x,-3:000}";

                return new Product
                {
                    ProductNumber = $"{department.First()}{name.First()}{productId}",
                    Name = $"{adjective} {material} {name}",
                    Price = (double)rnd.Next(100, 900) / 10,
                    Department = department
                };
            }));

            context.SaveChanges();
        }
    }
}