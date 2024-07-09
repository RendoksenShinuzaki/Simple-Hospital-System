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
    internal class PatientModel
    {
        [BsonId]
        public ObjectId ID { get; set; }

        [BsonElement("Patient ID")]
        public string PatientID { get; set; }

        [BsonElement("First Name")]
        public string FirstName { get; set; }

        [BsonElement("Middle Name")]
        public string MiddleName { get; set; }

        [BsonElement("Last Name")]
        public string LastName { get; set; }

        [BsonElement("Gender")]
        public string Gender { get; set; }

        [BsonElement("Age")]
        public int Age { get; set; }

        [BsonElement("Diagnosis")]
        public string Diagnosis { get; set; }

        //[BsonElement("Treatment")]
        //public string Treatment { get; set; }

        [BsonElement("Symptoms")]
        public string Symptoms { get; set; }

        //[BsonElement("Date")]
        //public string Date { get; set; }

        public PatientModel(string patientid, string firstname, string middlename, string lastname, string gender, int age, string symptoms)
        {
            PatientID = patientid;
            FirstName = firstname;
            MiddleName = middlename;
            LastName = lastname;
            Gender = gender;
            Age = age;
            //Diagnosis = diagnosis;
            //Treatment = treatment;
            Symptoms = symptoms;
            //Date = date;
        }
    }
}
