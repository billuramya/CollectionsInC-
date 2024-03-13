using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.GenericCollections
{
    internal class StackLists
    {
        public void GetStackList()
        {
            Stack <int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5); 


            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek()); 

        }
    }
}
