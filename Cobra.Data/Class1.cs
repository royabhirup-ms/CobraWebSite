using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobra.Data
{
    public class Class1
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public Class1()
        {
            // Removed myData() call from constructor to prevent infinite recursion
        }

        public string myData()
        {
            string jsonString = @"{
                'Name': 'John Doe',
                'Age': 30,
                'City': 'New York'
            }";

            // Use a separate class or anonymous object for deserialization
            var personData = JsonConvert.DeserializeAnonymousType(jsonString, new { Name = "", Age = 0, City = "" });
            string appName = "Cobra";
            appName = appName + " Website Deploy Test From Class Library for " + personData.Name + " in " + personData.City + " age: " + personData.Age;
            return appName;
        }
    }
}
