using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollections
{
    public class SortedLists
    {
        public void sortedListsCreate()
        {
            SortedList sort1 = new SortedList();
            sort1.Add( 1, "hello");
            sort1.Add(2, "ramya");
            sort1.Add(3, 1000);
            sort1.Add(4, 45.5);

            //removing key-value
            sort1.Remove(1);

            // clone 
            SortedList s2=(SortedList)sort1.Clone();
            foreach (var item in s2.Keys) {
                Console.WriteLine("clone key :{0} ,value :{1}", item, s2[item]);
            }

            //contains 
            bool result=s2.Contains(1);
            bool result1 = s2.ContainsKey(2);
            var result2 = s2.ContainsValue("ramya");
            Console.WriteLine("contains result of key  :{0} {1} {2}", result,result1,result2);

            foreach( var item  in sort1.Keys)
            {
                Console.WriteLine("key :{0} ,values: {1}",item,sort1[item]);
            }
        }
    }
}
