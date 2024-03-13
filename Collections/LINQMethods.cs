using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Collections
{
    internal class LINQMethods
    {
        public void Aggregations()
        {
            int[] nums = { 1, 2, 4, 6, 7, 8, 93, 45, 23, 24 };
            Console.WriteLine(nums.Max());
            Console.WriteLine(nums.Min());
            Console.WriteLine(nums.Sum());
            Console.WriteLine(nums.Average());
            Console.WriteLine(nums.Count());
            var result = nums.Aggregate((a, b) => a * b);
            Console.WriteLine(result);

        }

        public void RestrictionOperator()
        {
            List <int> nums = new List<int>() { 1,2,3,4,5,6,7,8,9};
           var result= nums.Where(x => x % 2 == 0);
           var result1=nums.Select((nums,index) => new {Number=nums,Index=index})
                .Where(x=>x.Number %2==0).Select(x=>x.Number);
            foreach(var x in result1) { Console.WriteLine(x); }

        }
        
    }
   internal class Student
    {
        public string Name { get; set; }
        public string Gender { get; set; }

        public List<string> Subjects { get; set; }
        public static List<Student> GetAllStudents()
        {
            List<Student> StudentsList = new List<Student>()
            { new Student { Name = "AAA", Gender = "Male", Subjects =new List<string> {"c#","ASP"}},
             new Student { Name = "BBB", Gender = "FeMale", Subjects =new List<string> {"Python","java"}},
             new Student { Name = "CCC", Gender = "FeMale", Subjects =new List<string> {"c#",".Net"}},
             new Student { Name = "DDD", Gender = "Male", Subjects =new List<string> {"SQL","Angular"}},
             new Student { Name = "EEE", Gender = "Male", Subjects =new List<string> {"c#","java"}},
             new Student { Name = "FFF", Gender = "FeMale", Subjects =new List<string> {"HTML","CSS"}}


            };

            return StudentsList;

        }
    }
    internal class GetStudentsList
    {
        public void GetStudents()
        {
          var results = Student.GetAllStudents().Select(std => (std.Gender,std.Name,std.Subjects)).Distinct();

            foreach (var stds in results)
            {
                foreach (var student in stds.Subjects)
                {
                    Console.WriteLine(stds.Name + "\t" + stds.Gender + "\t" + student);
                }
            }
        }
    } 

    public class OrderingMethod
    {
        public void AccendingAndDescending()
        {
            Console.WriteLine("Accensinding order");

            var results = Student.GetAllStudents().OrderBy(x => x.Name).ThenBy(s=>s.Gender);
            foreach (var std2 in results)
            {
                Console.WriteLine(std2.Name+"\t"+std2.Gender);
            }
            Console.WriteLine("Descending order");
            var results1 = Student.GetAllStudents().OrderByDescending(x => x.Name).ThenByDescending(s => s.Gender);
            foreach (var std1 in results1)
            {
                Console.WriteLine(std1.Name + "\t" + std1.Gender);
            }

            Console.WriteLine("Reverse the list");
            List<int> lists = new List<int>() { 1, 2, 3, 4, 5 };
            
            lists.Reverse();
            foreach (var list in lists)
            {
                Console.Write(list+" ");
            }
        }
    }   

    public class PartitionMethod
    {
        public void PartitionMethods()
        {
            List<string> list = new List<string>() { "one","two","three","four","five","six","seven"};
            var result1 = list.Take(3);
            var result2 = list.Skip(2);
            var result3 = list.TakeWhile(s => s.Length > 3);
            var result4=list.SkipWhile(s=> s.Length > 3);
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
        }
    }

}
