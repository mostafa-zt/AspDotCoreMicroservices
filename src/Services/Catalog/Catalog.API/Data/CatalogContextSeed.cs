using System;
using System.Collections.Generic;
using Catalog.API.Entities;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(x => true).Any();
            if (!existProduct)
            {
                productCollection.InsertMany(GetProducts());
            }
        }

        private static IEnumerable<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Category = "Tablet",
                    Description ="This is Tablet",
                    Name ="Tablet X10",
                    Price= 430,
                    Summary ="This is tablet for sale",
                    Id = ObjectId.GenerateNewId().ToString()
                },
                new Product()
                {
                    Category = "Smart Phone",
                    Description ="This is IPhone",
                    Name ="IPhone X",
                    Price= 430,
                    Summary ="This is Smart Phone for sale",
                    Id = ObjectId.GenerateNewId().ToString()
                },
                new Product()
                {
                    Category = "Smart Phone",
                    Description ="This is IPhone",
                    Name ="IPhone 7",
                    Price= 550,
                    Summary ="This is IPhone for sale",
                    Id = ObjectId.GenerateNewId().ToString()
                },
                new Product()
                {
                    Category = "Tablet",
                    Description ="This is Tablet",
                    Name ="Tablet X10",
                    Price= 430,
                    Summary ="This is tablet for sale",
                    Id = ObjectId.GenerateNewId().ToString()
                },
                new Product()
                {
                    Category = "Tablet",
                    Description ="This is Tablet",
                    Name ="Tablet X10",
                    Price= 430,
                    Summary ="This is tablet for sale",
                    Id = ObjectId.GenerateNewId().ToString()
                },
                new Product()
                {
                    Category = "Tablet",
                    Description ="This is Tablet",
                    Name ="Tablet X10",
                    Price= 430,
                    Summary ="This is tablet for sale",
                    Id = ObjectId.GenerateNewId().ToString()
                },
                new Product()
                {
                    Category = "Tablet",
                    Description ="This is Tablet",
                    Name ="Tablet X10",
                    Price= 430,
                    Summary ="This is tablet for sale",
                    Id = ObjectId.GenerateNewId().ToString()
                },
                new Product()
                {
                    Category = "Tablet",
                    Description ="This is Tablet",
                    Name ="Tablet X10",
                    Price= 430,
                    Summary ="This is tablet for sale",
                    Id = ObjectId.GenerateNewId().ToString()
                },
                new Product()
                {
                    Category = "Tablet",
                    Description ="This is Tablet",
                    Name ="Tablet X10",
                    Price= 430,
                    Summary ="This is tablet for sale",
                    Id = ObjectId.GenerateNewId().ToString()
                },
            };
        }
    }
}