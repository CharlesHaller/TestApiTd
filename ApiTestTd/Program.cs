using Microsoft.Owin.Hosting;
using System;
using System.Net.Http;
using ApiTestTd.MongoDb;

namespace ApiTestTd
{
    public class Program
    {
        static void Main()
        {
            string baseAddress = "http://localhost:9000/";

            Singleton.Instance.setIDao(new BooksDAO());

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                // Create HttpCient and make a request to api/values 
                HttpClient client = new HttpClient();

                var response = client.GetAsync(baseAddress + "api/values").Result;

                Console.WriteLine(response);
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                Console.ReadLine();
            }
        }
    }
}