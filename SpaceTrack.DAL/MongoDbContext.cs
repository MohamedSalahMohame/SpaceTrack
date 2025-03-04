﻿using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using SpaceTrack.DAL.Model;

namespace SpaceTrack.DAL
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(string connectionString, string databaseName)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            _database = client.GetDatabase("SpaceTrack");

        }
        public IMongoCollection<User> Users => _database.GetCollection<User>("Users");
        public IMongoCollection<Satellite> Satellites => _database.GetCollection<Satellite>("Satellites");
        public IMongoCollection<ResetPasswordRequest> ResetPasswordRequests => _database.GetCollection<ResetPasswordRequest>("ResetPasswordRequests");
        public IMongoCollection<ContactMessage> ContactMessages => _database.GetCollection<ContactMessage>("ContactMessages");
        public IMongoCollection<Foremail> Foremails => _database.GetCollection<Foremail>("Foremails");


    }
}




