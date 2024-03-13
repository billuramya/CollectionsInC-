using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Collections.GenericCollections
{
    internal class Dictionary
    {
        public void GetDictionary()
        {
            Dictionary <int,string> dictvalues = new Dictionary<int,string>();
            dictvalues.Add(1, "India");
            dictvalues.Add(2, "UK");
            dictvalues.Add(3, "US");
            dictvalues.Add(4, "Canada");
            dictvalues.Add(5, "Austalia");

            //other iteration method 
            dictvalues.AsParallel().ForAll(x => Console.WriteLine(x.Key+"\t"+x.Value));

            //update 
            dictvalues[4] = "Andra Pradesh";
            dictvalues.Remove(5);

            //contains 
            Console.WriteLine(dictvalues.ContainsKey(5));
            Console.WriteLine(dictvalues.ContainsValue("Andra Pradesh"));


            foreach(KeyValuePair<int,string> kvp in dictvalues)
            {
                Console.WriteLine(kvp.Key+"\t"+kvp.Value);
            }
        }
    }
}
