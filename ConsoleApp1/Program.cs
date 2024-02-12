using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Employee employee = new()
            {
                Id = 1,
                FirsName = "JAY",
                LastName = "PM"
            };

            //Console.WriteLine("Employee full name: {0}", employee.EmpFullname());
            
            //string json = JsonConvert.SerializeObject(employee);
            //Console.WriteLine(json);

            //Employee result = JsonConvert.DeserializeObject<Employee>(json);
            //Console.WriteLine(result.EmpFullname());

            string jsonresult = ConvertToJson(employee);
            Console.WriteLine(jsonresult);

            Employee? objresult = ConvertToObject(jsonresult);
            Console.WriteLine(objresult?.EmpFullname());
        }

        static string ConvertToJson(Employee employee)
        {
            string json = JsonConvert.SerializeObject(employee);
            return json;
        }

        static Employee? ConvertToObject(string json)
        {
            Employee? result = JsonConvert.DeserializeObject<Employee>(json);
            return result;
        }

        class Employee
        {
            public int Id { get; set; }
            public string FirsName { get; set; }
            public string LastName { get; set; }

            public string EmpFullname()
            {
                return $"{FirsName} {LastName}";
            }

        }
    }
}
