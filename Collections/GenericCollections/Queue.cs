using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.GenericCollections
{
    internal class QueueLists
    {
        public void GetQueueList()
        {
            Queue<int> ints = new Queue<int>();
            ints.Enqueue(1);
            ints.Enqueue(2);
            ints.Enqueue(3);
            ints.Enqueue(4);
            ints.Enqueue(5);
            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }

            //remove 
            Console.WriteLine(ints.Dequeue());
            Console.WriteLine(ints.Peek());
        }
    }

}
