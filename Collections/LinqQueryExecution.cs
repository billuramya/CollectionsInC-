using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class LinqQueryExecution
    {
        public string Name { get; set; }
        public int TotalMatrks { get; set; }
        public void DefferedExpretion()
        {
            List<LinqQueryExecution> std = new List<LinqQueryExecution>()
            {
                new LinqQueryExecution{ Name="AAA",TotalMatrks=700},
                 new LinqQueryExecution{ Name="CCC",TotalMatrks=500},
                  new LinqQueryExecution{ Name="FFF",TotalMatrks=400},
                   new LinqQueryExecution{ Name="RRR",TotalMatrks=900},

            };
            var result = (from val in std where val.TotalMatrks > 400 select val).ToList();
            std.Add(new LinqQueryExecution { Name = "RAMYA", TotalMatrks = 1000 });

            foreach (var val in result)
            {
                Console.WriteLine(val.Name);
            }



        }



       

    }

}
        
            


    

    

    


