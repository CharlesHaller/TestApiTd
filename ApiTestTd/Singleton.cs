using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiTestTd.MongoDb;

namespace ApiTestTd
{
    public class Singleton
    {
        public static Singleton _instance;

        public IDao Idao { get; private set; }

        public void setIDao(IDao idao)
        {
            Idao = idao;
        }

        public static Singleton Instance
        {
            get { return _instance ?? (_instance = new Singleton()); }
        }
    }
}
