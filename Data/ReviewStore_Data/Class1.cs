using ReviewStore_Models;
using System;
using System.Collections.Generic;

namespace ReviewStore_Data
{
    public interface IProductRepo
    {
        List<Product> GetList();
    }

    public class ProductRepo : IProductRepo
    {
        public List<Product> GetList()
        {
            var testProducts = new List<Product>();
            testProducts.Add(new Product { Id = 1, Name = "Demo1", Price = 1 });
            testProducts.Add(new Product { Id = 2, Name = "Demo2", Price = 3.75M });
            testProducts.Add(new Product { Id = 3, Name = "Demo3", Price = 16.99M });
            testProducts.Add(new Product { Id = 4, Name = "Demo4", Price = 11.00M });

            return testProducts;
        }
    }
}
