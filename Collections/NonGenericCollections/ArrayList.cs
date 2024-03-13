using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenricCollections
{
    class ArrayLists
    {
        public void addArrayList()
        {
            ArrayList Arr = new ArrayList();
            Arr.Add("Math");
            Arr.Add("english");
            Arr.Add("social");
            Arr.Add("sceince");
            Arr.Add("hindi");

            // inserting 

            Arr.Insert(2, "telugu");
            ArrayList Arr2 = new ArrayList();
            Arr2.Add(100);
            Arr2.Add(200);

            Arr2.InsertRange(2, Arr);

            //removing values
            Arr2.Remove("hindi");
            Arr2.RemoveAt(2);
            Arr2.RemoveRange(0, 2);

            //sort
            Arr.Sort();


            foreach (var i in Arr2)
            {
                Console.WriteLine(i);
            }

            // element exist or not
            bool result = Arr.Contains("telugu");
            Console.WriteLine(result);

            

            //capacity 
            Console.WriteLine(Arr2.Capacity);
            Console.WriteLine(Arr.Capacity);

            //clone
            Arr2=(ArrayList) Arr.Clone();
            foreach (var i in Arr2)
            {
                Console.WriteLine(i);
            }

            // clear the element
            Arr.Clear();


        }
    }
}
