//논리연산자
// && 연산자 (AND) : 둘 다 참일때에만 참, 즉, 하나라도 거짓이면 거짓
// || 연산자 (OR) : 하나라도 참이면 참, 즉, 둘 다 거짓일때에만 거짓
// ! 연산자(NOT) : 참이면 거짓으로, 거짓이면 참으로
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 논리연산자
{
    class LogicalOperator
    {
        public static void Main(string[] args)
        {
            int i = 3;
            int j = 5;

            bool r = false;

            r = (i == 3) && (j != 3); //r = true && true
            Console.WriteLine(r);
            
            r = (i != 3) || (j == 3); //r = false && false
            Console.WriteLine(r);

            r = (i >= 5); //r => false
            Console.WriteLine("{0}", !r); //false <-> true
        }

    }
}
