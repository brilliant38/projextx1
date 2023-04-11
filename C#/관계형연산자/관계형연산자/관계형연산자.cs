using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 관계형연산자
{
    class 관계형연산자
    {
        static void Main(string[] args)
        {
            int firstNum = 10;
            int secondNum = 5;
            bool r = false;
            

            Console.WriteLine(firstNum>secondNum);// true

            r = (firstNum <= secondNum); //false;
            Console.WriteLine(r);

            r = (firstNum == secondNum); //C family : ==, VB Family : =
            Console.WriteLine(r); //false 
            
            r = (firstNum != secondNum); //C family : !=, VB Family : =
            Console.WriteLine(r); //true


        }
            
    }
}
