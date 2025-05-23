﻿using CoffeeShop.Models.Interfaces;

namespace CoffeeShop.Models.Services
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> ProductsList = new List<Product>()
        {
            new Product{ Id = 1, Name = "America", Price = 25, Detail = "Name product", ImageUrl = "https://index.com", IsTrendingProduct = true },
            new Product{ Id = 2, Name = "Vietnam", Price = 20, Detail = "Vietnamese product", ImageUrl = "https://index.com", IsTrendingProduct = false },
            new Product{ Id = 3, Name = "United Kingdom", Price = 15, Detail = "UK product", ImageUrl = "https://index.com", IsTrendingProduct = true }
        };

        public IEnumerable<Product> GetAllProducts() => ProductsList;

        public Product? GetProductDetail(int id) =>
            ProductsList.FirstOrDefault(p => p.Id == id);

        public IEnumerable<Product> GetTrendingProducts() =>
            ProductsList.Where(p => p.IsTrendingProduct);
    }
}
