using Newtonsoft.Json;
using System;
using System.Linq;

namespace FrankenPeople
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToGenerate = 10;
            var testData = GetBogus.FakeData.Generate(numberToGenerate).ToList();
            Console.WriteLine(JsonConvert.SerializeObject(testData, Formatting.Indented));
        }


    }
}
