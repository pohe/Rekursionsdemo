using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Rekursionsdemo
{
    class Program
    {
        private static int Fakultet(int v)
        {

            if (v == 1)
            {
                return 1;
            }
            else {
                return v * Fakultet(v - 1);
            }
        }

        private static int FakultetIterativ(int v)
        {
            int result = 1;
            for (int i = v; i > 0; i--)
            {
                result = result * i;
            }

            return result;
        }

        private static int Fibonacci(int v)
        {
            if (v <= 1)
                return 1;
            else
            {
                return Fibonacci(v - 1) + Fibonacci(v - 2);
            }
        }

        private static int FibonacciIterativt(int v)
        {
            
            if (v == 1 || v == 0)
                return 1;
            else
            {
                int result = 0;

                int forrige = 1;
                int nextforrige = 1;
                Console.WriteLine($"Inde i fib forrige:{forrige} nextforrige: {nextforrige} result:{result}");

                for (int i = 2; i <= v; i++)
                {
                    result = forrige + nextforrige;
                    nextforrige = forrige;
                    forrige = result;
                    Console.WriteLine($"Inde i fib forrige:{forrige} nextforrige: {nextforrige} result:{result}");
                }

                return result; 
            }
            
        }

        private static bool ListSearchIterativt(List<int> searchList, int v)
        {
            foreach (int  tal in searchList)
            {
                if (tal == v)
                    return true;
                
            }
            return false; 
        }

        private static bool ListSearchRekursivt(List<int> searchList, int v)
        {

            if (searchList[0] == v)
                return true;
            else
            {
                if (searchList.Count <= 1)
                    return false;
                else
                {
                    return ListSearchRekursivt(searchList.GetRange(1, searchList.Count - 1), v);
                }
            }
        }
        static void Main(string[] args)
        {
            //int result = Fakultet(5);
            //Console.WriteLine(result);
            //int resultItFak = FakultetIterativ( 5);
            //Console.WriteLine(resultItFak);

            //int fibResult = Fibonacci(6);
            //Console.WriteLine(fibResult);
            //int fibItResult = FibonacciIterativt(6);
            //Console.WriteLine(fibItResult);
            List<int> searchList = new List<int>(){ 12, 4, 67, 8, 90, 2 };
            //bool resultSeach = ListSearchIterativt(searchList, 8);
            bool resultSeachRek = ListSearchRekursivt(searchList, 15);
            Console.WriteLine(resultSeachRek);
            Console.ReadLine();

        }

        
    }
}
