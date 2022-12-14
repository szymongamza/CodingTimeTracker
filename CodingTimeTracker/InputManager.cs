using CodingTimeTracker;
using ConsoleTableExt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTimeTracker
{
    public class InputManager
    {
        CodingController codingController = new CodingController();
        ValidationInput validationInput = new ValidationInput();
        public void InsertData()
        {
            string startTime = validationInput.DateTimeInput("start time of coding");
            string endTime = validationInput.DateTimeInput("end time of coding");
            codingController.InsertRecord(startTime, endTime);
        }
        public void InsertData(DateTime startTimeDT,DateTime endTimeDT)
        {
            string startTime = startTimeDT.ToString();
            string endTime = endTimeDT.ToString();
            codingController.InsertRecord(startTime, endTime);
        }
        public void GetData()
        {
            List<CodingSessionModel> listOfCodingSessions = codingController.GetAllRecords();
            ConsoleTableBuilder.From(listOfCodingSessions).ExportAndWriteLine();
        }
        public void DeleteData()
        {
            int id = validationInput.IntInput("Type in Id of the record that you want to delete.");
            codingController.DeleteRecord(id);
        }
        public void UpdateData()
        {
            int id = validationInput.IntInput("Type in Id of the record that you want to update.");
            string startTime = validationInput.DateTimeInput("start time of coding");
            string endTime = validationInput.DateTimeInput("end time of coding");
            codingController.UpdateRecord(id, startTime, endTime);
        }

    }
}
