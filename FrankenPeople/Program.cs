using Bogus;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace FrankenPeople
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToGenerate = 1;

            var testData1 = GetAllProperty.FakeAddress.Generate(numberToGenerate).ToList();
            Console.WriteLine(JsonConvert.SerializeObject(testData1, Formatting.Indented)); 

            var testData2 = GetAllProperty.FakeCommerce.Generate(numberToGenerate).ToList();
            Console.WriteLine(JsonConvert.SerializeObject(testData2, Formatting.Indented));

            var testData3 = GetAllProperty.FakeCompany.Generate(numberToGenerate).ToList();
            Console.WriteLine(JsonConvert.SerializeObject(testData3, Formatting.Indented));


            var testData4 = GetAllProperty.FakeDatabase.Generate(numberToGenerate).ToList();
            Console.WriteLine(JsonConvert.SerializeObject(testData4, Formatting.Indented));

            var testData5 = GetAllProperty.FakeDate.Generate(numberToGenerate).ToList();
            Console.WriteLine(JsonConvert.SerializeObject(testData5, Formatting.Indented));


            var testData6 = GetAllProperty.FakeFinance.Generate(numberToGenerate).ToList();
            Console.WriteLine(JsonConvert.SerializeObject(testData6, Formatting.Indented));

            var testData7 = GetAllProperty.FakeHacker.Generate(numberToGenerate).ToList();
            Console.WriteLine(JsonConvert.SerializeObject(testData7, Formatting.Indented));

            var testData8 = GetAllProperty.FakeInternet.Generate(numberToGenerate).ToList();
            Console.WriteLine(JsonConvert.SerializeObject(testData8, Formatting.Indented));


        }


    }
}
 