using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollection
{
     public class StackMethod
    {
        public void stackList() {
         Stack s1 = new Stack();
            s1.Push(100);
            s1.Push("Ramya");
            s1.Push(20000);
            s1.Push("hyd");

            Console.WriteLine("pop value:{0}",s1.Pop());
           
            var result =s1.Peek();
            Console.WriteLine("peak value :{0}",result);

            bool result2=s1.Contains(result);
            Console.WriteLine("Contain value {1} :{0}",result2,result);

            Stack s2=(Stack) s1.Clone();

            foreach(var i in s2)
            {
                Console.WriteLine("clone value :{0}",i);
            }


            foreach (var item in s1)
            {
                Console.WriteLine(item);
            }

            
        }
    }
}
