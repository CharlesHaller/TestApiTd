using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiTestTd.Model;

namespace ApiTestTd.MongoDb
{
    public interface IDao
    {
        Task<BooksModel> FindOne(int number);
        void InsertOne(BooksModel books);
        void DeleteOne(int number);
        void UpdateOne(BooksModel books);
        Task<List<BooksModel>> FindAll();
    }
}
