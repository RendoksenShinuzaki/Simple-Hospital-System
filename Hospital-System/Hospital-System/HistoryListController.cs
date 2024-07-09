using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System
{
    internal class HistoryListController
    {
        public void ViewList(DataGridView historylist)
        {
            var controller = new HistoryListController();
            PatientList patientList = new PatientList();
            var mongosingleton = DataBaseSingleton.GetInstance().GetDatabase();
            var collection = mongosingleton.GetCollection<PatientModel>("PatientsHistory");
            List<PatientModel> List = collection.AsQueryable().ToList();
            historylist.DataSource = List;
        }
    }
}
