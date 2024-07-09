using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System
{
    [BsonIgnoreExtraElements]
    internal class LoginModel
    {
        [BsonId]
        public ObjectId AccountID { get; set; }

        [BsonElement("ID")]
        public long ID { get; set; }

        [BsonElement("Password")]
        public string Password { get; set; }

        public LoginModel(long id, string password)
        {
            ID = id;
            Password = password;
        }
        public bool CheckCredentials(long inputId, string inputPassword)
        {
            if (inputId == ID && inputPassword == Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}


