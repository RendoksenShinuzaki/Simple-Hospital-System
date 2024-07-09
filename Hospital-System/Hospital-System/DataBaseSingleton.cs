using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZstdSharp.Unsafe;

namespace Hospital_System
{
    public sealed class DataBaseSingleton
    {
        public static DataBaseSingleton instance;
        public static IMongoDatabase database;

        public DataBaseSingleton()
        {
            var ad = new MongoClient("mongodb://localhost:27017");
            database = ad.GetDatabase("Hospital");
        }
        public static DataBaseSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new DataBaseSingleton();
            }
            return instance;
        }
        public IMongoDatabase GetDatabase()
        {
            return database;
        }
    }
}
