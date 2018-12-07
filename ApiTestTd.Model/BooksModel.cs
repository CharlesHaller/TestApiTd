using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace ApiTestTd.Model
{
    public class BooksModel
    {
        public ObjectId Id { get; set; }

        public int Number { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        //public  BooksModel(int Number, string Title, string Author)
        //{
        //    this.Number = Number;
        //    this.Title = Title;
        //    this.Author = Author;
        //}
    }
}

