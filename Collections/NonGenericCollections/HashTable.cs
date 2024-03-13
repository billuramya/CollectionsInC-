using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollection
{
     class HashTable
    {
        public void gethashtables() {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Name", "Ramya");
            hashtable.Add("age", 22);
            hashtable.Add("FavColour", "black");
            hashtable.Add("MobileNo", 6304796656);
            Console.WriteLine(hashtable.Contains("Name"));
            Console.WriteLine(hashtable["name"]);
            Console.WriteLine(hashtable.ContainsValue(22));

            Console.WriteLine(hashtable.ContainsKey("age"));

            Hashtable h2=(Hashtable) hashtable.Clone();
            Console.WriteLine(h2);

            foreach (var a in h2.Keys)
            {
                Console.WriteLine("key :{0},value:{0}",a,h2[a]);
            }
        }  
    }
}
