using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsList
{
    internal class LambdaExpretions
    {
        public void ExpressionLambda()
        {
            var maxValue = (int a) => a * a;
            Console.WriteLine(maxValue(2));
        }
        public void statementLambda()
        {
            var result = (int a, int b) =>
            {
                var mul = a * b;
                return mul;

            };
            Console.WriteLine( result(2,4));
        }
    }
}
