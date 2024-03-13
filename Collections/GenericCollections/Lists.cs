using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    internal class Lists
    {
       public void ListOperations()
        {
            //create list
            List <int> list1 = new List <int>();
            //add elements
            list1.Add (1);
            list1.Add (2);
            list1.Add (3);
            list1.Add (4);


            //add elements in range

            List<int> list2 = new List<int>() { 11, 12, 13, 14, };
            list1.AddRange (list2);


            //insert the elements purticular range
            list1.Insert(1, 100);
            // insert list of range 
            List<int> list3= new List<int> { 20, 21, 22, 23, };
            list1.InsertRange(1, list3);

            //contains elements
            bool result =list1.Contains (20);
            Console.WriteLine (result);

            //remove methods
            list1.Remove (20);
            list1.RemoveAt (1);
            list1.RemoveRange(2, 3);
            //Console.WriteLine("removing even numbers");
            list1.RemoveAll(x=> x%2==0);

            //copy the array 
            int[] array = { 100, 200, 300 };
            List<int> list4 = new List<int>(array);

            //finding element
            Console.WriteLine (list4.Find (x => x%2==0));

            //iteration
            foreach (int i in list4)
            {
                Console.WriteLine(i);
            }
            // iteration using for loop
            Console.WriteLine("using for loop iteration");
            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine(list1[i]);
            }
        }
    }
}
