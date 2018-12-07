using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ApiTestTd.Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ApiTestTd.MongoDb
{
    public class BooksDAO : IDisposable, IDao

    {
        private MongoClient _mongoClient;
        private IMongoDatabase _database;
        private IMongoCollection<BooksModel> _mongoCollection;

        public BooksDAO()
        {
            var MongoClient = new MongoClient("mongodb://localhost:27017");
            var database = MongoClient.GetDatabase("local");
            _mongoCollection = database.GetCollection<BooksModel>("books");
        }

        public async Task<BooksModel> FindOne(int number)
        {
            var query = await _mongoCollection.Find(book => book.Number == number).ToListAsync();

            return query.FirstOrDefault();

        }

        public async void InsertOne(BooksModel book)
        {
            await _mongoCollection.InsertOneAsync(book);
        }

        public async void DeleteOne(int number)
        {
            await _mongoCollection.DeleteOneAsync(book => book.Number == number);
        }

        public async void UpdateOne(BooksModel book)
        {
            await _mongoCollection.FindOneAndUpdateAsync(
                Builders<BooksModel>.Filter.Eq(b => b.Number, book.Number),
                Builders<BooksModel>.Update.Set(b => b.Number, book.Number)
                .Set(b =>b.Title, book.Title)
                .Set(b => b.Author , book.Author)
                );
        }

        public async Task<List<BooksModel>>FindAll()
        {
            return await _mongoCollection.Find(new BsonDocument()).ToListAsync();
            
        }

        public void Dispose()
        {
            _mongoCollection = null;
            _database = null;
            _mongoClient = null;
        }

    }
}
