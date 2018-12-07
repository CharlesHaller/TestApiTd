using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiTestTd;
using ApiTestTd.Model;
using ApiTestTd.MongoDb;
using Castle.Components.DictionaryAdapter.Xml;
using NSubstitute;
using NUnit.Framework;

namespace ApiTestTdTest
{
    [TestFixture]
        public class Class1
    {
        [Test]
        public void TestFindOne()
        {
            var idao = Substitute.For<IDao>();
            Singleton.Instance.setIDao(idao);

            var controller = new ValuesController();
            controller.Get(1);

            idao.Received(1).FindOne(Arg.Is(1));
        }

        [Test]
        public void TestUpdateOne()
        {
            var idao = Substitute.For<IDao>();
            Singleton.Instance.setIDao(idao);

            var controller = new ValuesController();
            controller.Put(new BooksModel());

            idao.Received(1).UpdateOne(Arg.Any<BooksModel>());
        }

        [Test]
        public void TestDeleteOne()
        {
            var idao = Substitute.For<IDao>();
            Singleton.Instance.setIDao(idao);

            var controller = new ValuesController();
            controller.Get(1);

            controller.Delete(1);
            idao.Received(1).DeleteOne(Arg.Is(1));
        }

        [Test]
        public void TestInsertOne()
        {
            var idao = Substitute.For<IDao>();
            Singleton.Instance.setIDao(idao);

            var controller = new ValuesController();
            controller.Post(new BooksModel());

            idao.Received(1).InsertOne(Arg.Any<BooksModel>());
        }

        [Test]
        public void TestFindAll()
        {
            var idao = Substitute.For<IDao>();
            Singleton.Instance.setIDao(idao);

            var controller = new ValuesController();
            controller.Get();

            idao.Received(1).FindAll();
        }
    }
}
