using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(Add4(2, 4, 6, 4, 3, 3, 23, 231, 2134));
            Console.ReadLine();
            //    //Add();
            //    //var result1 = Add2(1, 3);
            //    //Console.WriteLine("Result: {0}", result1);
            //    int number1 = 20;
            //    int number2 = 100;
            //    var result2 = Add3(ref number1, number2);
            //    Console.WriteLine("Result2: {0}", result2);
            //    Console.WriteLine(number1);


            //    Console.ReadLine();
            //}
            //static void Add()
            //{
            //    Console.WriteLine("Added!");
            //}
            //static int Add2(int number1 ,int number2=30)
            //{
            //    int result=number1 + number2;
            //    //Console.WriteLine("Result: {0}", result);
            //    return result;
            //}

            //static int Add3(ref int number1,int number2)
            //{
            //    number1 = 30;
            //    return number1 + number2;
            //
            int Multiply(int number1, int number2)
            {
                return number1 * number2;
            }


            int Add4(params int[] numbers)
            {
                return numbers.Sum();
            }



        }
    }
}
