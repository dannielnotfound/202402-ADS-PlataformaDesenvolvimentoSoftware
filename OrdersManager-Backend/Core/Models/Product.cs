﻿namespace Core.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public IEnumerable<Order> orders { get; set; } = new List<Order>();

        private Product() { }

        public Product(string id, string name, string description, double price)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
        }

        public Product(string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
