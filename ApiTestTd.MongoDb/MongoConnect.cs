using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiTestTd.Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ApiTestTd.MongoDb
{
    public class MongoConnect
    {
        private IMongoCollection<BooksModel> _collection;

        //Connexion to database

        public MongoConnect()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("local");
            _collection = database.GetCollection<BooksModel>("books");
        }
    }
}
