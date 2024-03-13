using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class FirstProblem
    {
        public void NonGeneric() {
            Console.WriteLine("Non generic method max value");
            int[] list1 = { 10, 30, 20 };
            string[] str1 = { "Ramya", "Siva", "Naresh" };
            float[] float1 = { 10.4f, 2.44f, 2.5f };
            Console.WriteLine(list1.Max());
            Console.WriteLine(str1.Max());
            Console.WriteLine(float1.Max());
        }
        public void Generic() {

            Console.WriteLine("Generic method max value");
            List<int> maxList = new List<int> { 10, 30, 20 };
            List<string> maxString = new List<string> { "Ramya", "Siva", "Naresh" };
            List <float> maxFloat = new List<float> { 10.4f, 2.44f, 2.5f };
            Console.WriteLine(maxList.Max());
            Console.WriteLine(maxString.Max());
            Console.WriteLine(maxFloat.Max());
        }
    }  
    internal class SecondProblem
    {
        //given array of ineger ,double,char write a program to print the same
        public void NonGeneric()
        {
            int[] integerList= { 10, 30, 20 };
            char[] charList = { 'a', 'b', 'c', };
            double[] doubleList = { 2.3, 5.3, 4.5 }; 

            foreach (int i in integerList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            foreach (double i in doubleList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            foreach (char i in charList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

        }
        
        public void Generic()
        {
            int[] integerList = { 10, 30, 20 };
            printArray(integerList);
            Console.WriteLine();
            char[] charList = { 'a', 'b', 'c', };
            printArray(charList);
            Console.WriteLine();
            double[] doubleList = { 2.3, 5.3, 4.5 };
            printArray(doubleList);
            Console.WriteLine();
        }
        public void printArray<T>( T[] ArrayList)
        {
            foreach (var i in ArrayList)
            {
                Console.WriteLine(i+" ");
            }

        }
    }
}
