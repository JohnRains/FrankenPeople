using Bogus;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FrankenPeople
{
    public class SandBox
    {

        static private string[] testArray = new string[] 
            { "On", "the", "other", "hand", "we", "denounce", "with", "righteous", "indignation", "and", "dislike", "men", "who", "are", "so", "beguiled" };

        static private List<string> testList = new List<string>(
            new string[] { "On", "the", "other", "hand", "we", "denounce", "with", "righteous", "indignation", "and", "dislike", "men", "who", "are", "so", "beguiled" });

        static string testSymbols = "!@#$%^&*()";

        static char Replace()
        {
            return '?';
        }

        public void Init()
        {
            Faker f = new Faker();
            __Random r = new __Random();

            Console.WriteLine(" *** Random Addendum -- Not Implemented by Rules *** ");
            r.ArrayElement = f.Random.ArrayElement(testArray).ToString();
            Console.WriteLine(JsonConvert.SerializeObject(r.ArrayElement, Newtonsoft.Json.Formatting.Indented));
            r.ArrayElements = f.Random.ArrayElements(testArray).ToArray();
            Console.WriteLine(JsonConvert.SerializeObject(r.ArrayElements, Newtonsoft.Json.Formatting.Indented));
            r.ListItem = f.Random.ListItem(testList).ToString();
            Console.WriteLine(JsonConvert.SerializeObject(r.ListItem, Newtonsoft.Json.Formatting.Indented));
            r.ListItems = f.Random.ListItems(testList).ToArray();
            Console.WriteLine(JsonConvert.SerializeObject(r.ListItems, Newtonsoft.Json.Formatting.Indented));
            r.CollectionItem = f.Random.CollectionItem(testList).ToString();
            Console.WriteLine(JsonConvert.SerializeObject(r.CollectionItem, Newtonsoft.Json.Formatting.Indented));
            r.ReplaceSymbols = f.Random.ReplaceSymbols(testSymbols, '$', Replace);
            Console.WriteLine(JsonConvert.SerializeObject(r.ReplaceSymbols, Newtonsoft.Json.Formatting.Indented));
            r.Shuffled = f.Random.Shuffle(testList).ToList();
            Console.WriteLine(JsonConvert.SerializeObject(r.Shuffled, Newtonsoft.Json.Formatting.Indented));

        }

    }
}
