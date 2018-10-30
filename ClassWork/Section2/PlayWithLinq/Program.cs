using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithLinq
{
    class Program
    {
        static void Main( string[] args )
        {
            var Products = GetProducts();
            //get discounted products
            //var dicounted = Products.Where(IsDiscounted);
            var dicounted = Products.Where(p => p.IsDiscounted); //this is a Lambda

            var expensive = Products.FirstOrDefault(p => p.Price > 100);

            //demo statment lambda, rather then exspression lambda
            var discountedExpensive = Products.Where(p => {
                return p.IsDiscounted && p.Price > 100;
            });

            var subsetProducts = Products.Select(p => new { Name = p.Name, Price = p.Price });

            var exspensiveSubset = subsetProducts.Where(p => p.Price > 100);
        }

        //static bool IsDiscounted (Product product)
        //{
        //    return product.IsDiscounted;
        //}    This is no longer needed due to the Lamba

        static IEnumerable<Product> GetProducts ()
        {
            return new[]
            {
                new Product() { Name = "Product A", Price = 50, IsDiscounted = false },
                new Product() { Name = "Product B", Price = 150, IsDiscounted = true },
                new Product() { Name = "Product C", Price = 75, IsDiscounted = false },
                new Product() { Name = "Product D", Price = 105, IsDiscounted = true },
                new Product() { Name = "Product E", Price = 95, IsDiscounted = false },
                new Product() { Name = "Product F", Price = 5, IsDiscounted = true },
                new Product() { Name = "Product G", Price = 10, IsDiscounted = false },
                new Product() { Name = "Product H", Price = 200, IsDiscounted = true },
            };
        }
    }

    class Product
    {
        public string Name { get; set; }
        public bool IsDiscounted { get; set; }
        public decimal Price { get; set; }
    }
}
