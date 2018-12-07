using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using ApiTestTd.Model;
using ApiTestTd.MongoDb;
using Exception = System.Exception;

namespace ApiTestTd
{
    public class ValuesController : ApiController
    {
        // GET api/values 
        public IHttpActionResult Get()
        {
            Singleton.Instance.Idao.FindAll();

            return Ok();
        }

        // GET api/values/5 
        public IHttpActionResult Get(int id)
        {
            Singleton.Instance.Idao.FindOne(id);

                return Ok();

        }

        // POST api/values 
        public IHttpActionResult Post(BooksModel books)
        {
            Singleton.Instance.Idao.InsertOne(books);
            return Ok();

        }

        // PUT api/values/5 
        public IHttpActionResult Put(BooksModel books)
        {
            Singleton.Instance.Idao.UpdateOne(books);
            return Ok();
        }

        // DELETE api/values/5 
        public IHttpActionResult Delete(int id)
        {
            Singleton.Instance.Idao.DeleteOne(id);
            return Ok();
        }
    }
}