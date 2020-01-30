using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionExample
{
    public interface IProductStockRepository
    {
        bool isInStock(Product product);
        void ReduceStock(Product product);
        void AddStock(Product product);

    }
    public class ProductStockRepository : IProductStockRepository
    {
        private static Dictionary<Product, int> _productStockDatabase = Setup();

        private static Dictionary<Product, int> Setup()
        {
            Dictionary<Product, int> productStockDatabase = new Dictionary<Product, int>();

            productStockDatabase.Add(Product.Keyboard, 1);
            productStockDatabase.Add(Product.Mic, 1);
            productStockDatabase.Add(Product.Mouse, 1);
            productStockDatabase.Add(Product.Speaker, 1);

            return productStockDatabase;
        }

        public bool isInStock(Product product)
        {
            Console.WriteLine("PSEUDO DB <<GET>>");
            return _productStockDatabase[product] > 0;
        }

        public void ReduceStock(Product product)
        {
            Console.WriteLine("PSEUDO DB <<UPDATE>>");
            _productStockDatabase[product]--;
        }

        public void AddStock(Product product)
        {
            Console.WriteLine("PSEUDO DB <<UPDATE>>");
            _productStockDatabase[product]++;
        }
    }
}
