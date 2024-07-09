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
    internal class DoctorModel
    {
        [BsonId]
        public ObjectId DoctorID { get; set; }

        [BsonElement("First Name")]
        public string FirstName { get; set; }

        [BsonElement("Middle Initial")]
        public string MiddleName { get; set; }

        [BsonElement("Last Name")]
        public string LastName { get; set; }

        [BsonElement("Age")]
        public int Age { get; set; }

        [BsonElement("Doctor's Fee")]
        public int DoctorFee { get; set; }

        public DoctorModel(string firstName, string middleName, string lastName, int age, int doctorFee)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Age = age;
            DoctorFee = doctorFee;
        }
    }
}
