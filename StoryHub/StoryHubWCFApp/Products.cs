﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StoryHubWCFApp
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int ProductId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string CategoryName { get; set; }
        [DataMember]
        public int Price { get; set; }

    }

    public partial class Products
    {
        private static readonly Products _instance = new Products();
        private Products() { }
        public static Products Instance
        {
            get { return _instance; }
        }
        public List<Product> ProductList
        {
            get { return products; }
        }
        private List<Product> products = new List<Product>()
        {
            new Product() { ProductId = 1, Name = "Product 1", CategoryName = "Category 1", Price=10 },
            new Product() { ProductId = 1, Name = "Product 2", CategoryName = "Category 2", Price=10 },
            new Product() { ProductId = 1, Name = "Product 3", CategoryName = "Category 3", Price=10 },
            new Product() { ProductId = 1, Name = "Product 4", CategoryName = "Category 4", Price=10 }
        };
    }
}
