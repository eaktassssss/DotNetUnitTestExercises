﻿using MongoDB.Driver;
using UnitTestExercises.Core.Entities;

namespace UnitTestExercises.Infrastructure
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(MongoDbSettings settings)
        {
            var client = new MongoClient(settings.ServerUrl);
            _database = client.GetDatabase(settings.DatabaseName);
        }

        public IMongoCollection<Order> Orders
        {
            get
            {
                return _database.GetCollection<Order>("Orders");
            }
        }

        public IMongoCollection<Product> Products
        {
            get
            {
                return _database.GetCollection<Product>("Products");
            }
        }
    }
}