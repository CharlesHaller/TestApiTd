using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiTestTd;
using ApiTestTd.Model;
using ApiTestTd.MongoDb;
using NSubstitute;
using NUnit.Framework;

namespace ApiTestTdTest
{
    [TestFixture]
    class TestController
    {
        //private BooksModel myBook;
        //private ValuesController myController;
        //private IDao myDao;

        //[SetUp]
        //public void Setup()
        //{
        //    myBook = new BooksModel(2, "titre", "auteur");
        //    myController = new ValuesController();
        //    var myDao = Substitute.For<IDao>();
        //    Singleton.Instance.setIDao(myDao);
        //}
        //[TearDown]
        //public void Teardown()
        //{
        //    myDao.ClearReceivedCalls();
        //}

        //[Test]
        //public void TestGet()
        //{
        //    myController.Get();
        //    myDao.Received(1).FindAll();
        //}

        //[Test]
        //public void TestGetId()
        //{

        //    myController.Get(1);

        //    myDao.Received(1).FindOne(Arg.Is(1));
        //}

    }
}