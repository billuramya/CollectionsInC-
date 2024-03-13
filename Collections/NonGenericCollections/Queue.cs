using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollections
{
    public class QueueList
    {
        public void  QueueLists() {
            Queue queue1 = new Queue();
            queue1.Enqueue("Hello");
            queue1.Enqueue("Ramya");
            queue1.Enqueue(200000);
            queue1.Enqueue("Tirupati");

            //peek value
            Console.WriteLine("peek element :{0}",queue1.Peek());   

            //constains
            bool result = queue1.Contains("Hello");
            Console.WriteLine("contains element :{0}",result);

            // clone
            Queue q2=(Queue)queue1.Clone();
             foreach(var item in q2)
            {
                Console.WriteLine("Clone Elements:{0}",item);
            }


            //delete element
            queue1.Dequeue();

            foreach (var item in queue1)
            {
                Console.WriteLine(item);
            }

    }
    }
}
