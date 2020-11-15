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

            var adjectives = new[] { "ZSmall", "ZErgonomic", "ZRustic", "ZSZmart", "Sleek" };
            var materials = new[] { "ZSteel", "ZWooden", "ZConcrete", "ZPlastic", "Granite", "Rubber" };
            var names = new[] { "ZChair", "ZCar", "ZComputer", "ZPants", "ZShoes" };
            var departments = new[] { "ZBooks", "ZMovies", "ZMusic", "ZGames", "ZElectronics" };

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
                    Price = (double)rnd.Next(1000, 9000) / 100,
                    Department = department
                };
            }));

            context.SaveChanges();
        }
    }
}