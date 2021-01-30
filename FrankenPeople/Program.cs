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
            Console.WriteLine(" *** Address *** ") ;
            Console.WriteLine(JsonConvert.SerializeObject(testData1, Formatting.Indented)); 

            var testData2 = GetAllProperty.FakeCommerce.Generate(numberToGenerate).ToList();
            Console.WriteLine(" *** Commerce *** ") ;
            Console.WriteLine(JsonConvert.SerializeObject(testData2, Formatting.Indented));

            var testData3 = GetAllProperty.FakeCompany.Generate(numberToGenerate).ToList();
            Console.WriteLine(" *** Company *** ") ;
            Console.WriteLine(JsonConvert.SerializeObject(testData3, Formatting.Indented));


            var testData4 = GetAllProperty.FakeDatabase.Generate(numberToGenerate).ToList();
            Console.WriteLine(" *** Database *** ") ;
            Console.WriteLine(JsonConvert.SerializeObject(testData4, Formatting.Indented));

            var testData5 = GetAllProperty.FakeDate.Generate(numberToGenerate).ToList();
            Console.WriteLine(" *** Date *** ") ;
            Console.WriteLine(JsonConvert.SerializeObject(testData5, Formatting.Indented));


            var testData6 = GetAllProperty.FakeFinance.Generate(numberToGenerate).ToList();
            Console.WriteLine(" *** Finance *** ") ;
            Console.WriteLine(JsonConvert.SerializeObject(testData6, Formatting.Indented));

            var testData7 = GetAllProperty.FakeHacker.Generate(numberToGenerate).ToList();
            Console.WriteLine(" *** Hacker *** ") ;
            Console.WriteLine(JsonConvert.SerializeObject(testData7, Formatting.Indented));

            var testData8 = GetAllProperty.FakeInternet.Generate(numberToGenerate).ToList();
            Console.WriteLine(" *** Internet *** ");
            Console.WriteLine(JsonConvert.SerializeObject(testData8, Formatting.Indented));


            var testData9 = GetAllProperty.FakeName.Generate(numberToGenerate).ToList();
            Console.WriteLine(" *** Name *** ");
            Console.WriteLine(JsonConvert.SerializeObject(testData9, Formatting.Indented));


            var testData10 = GetAllProperty.FakePhone.Generate(numberToGenerate).ToList();
            Console.WriteLine(" *** Phone *** ");
            Console.WriteLine(JsonConvert.SerializeObject(testData10, Formatting.Indented));


            var testData11 = GetAllProperty.FakeRant.Generate(numberToGenerate).ToList();
            Console.WriteLine(" *** Rant *** ");
            Console.WriteLine(JsonConvert.SerializeObject(testData11, Formatting.Indented));


            var testData12 = GetAllProperty.FakeSystem.Generate(numberToGenerate).ToList();
            Console.WriteLine(" *** System *** ");
            Console.WriteLine(JsonConvert.SerializeObject(testData12, Formatting.Indented));


            var testData13 = GetAllProperty.FakeVehicle.Generate(numberToGenerate).ToList();
            Console.WriteLine(" *** Vehicle *** ");
            Console.WriteLine(JsonConvert.SerializeObject(testData13, Formatting.Indented));


            /* This section is not useful as, especially those of "Type" require an object to manipulate
             * It is here as a placeholder to remind me that I need to work more closely on each of them
             */
            var testData14 = GetAllProperty.FakeRandom.Generate(numberToGenerate).ToList();
            Console.WriteLine(" *** Random *** ");
            Console.WriteLine(JsonConvert.SerializeObject(testData14, Formatting.Indented));



            
        }


    }
}
 