using DataMover.Model;

namespace DataMover.Services{

    public class DataIngestionService
    {
        public void IngestData(List<string> empDataList)
        {
            for(int index = 0; index< empDataList.Count();index++ )
            {
                    EmployeeDataModel employeeDataModel = new EmployeeDataModel();
                    Console.WriteLine($" index  - {index}, Data - {empDataList[index]}");
            }
        }
    }
}
