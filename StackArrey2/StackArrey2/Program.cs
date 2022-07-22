using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackArrey2
{
    internal class Program
    {
        public int[] StckArray;
        public int top;
        static void Main(string[] args)
        {
        }
        bool isfull()
        {
            if (top >= StckArray.Length)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        
        bool push (int a)
        {
            if (!isfull())
            {
                top++;
                a = StckArray[top];
                return true;
            }
            else
            {
               return false;
            }
        }
        bool pop()
        {
            if (!isfull())
            {
                Console.WriteLine(StckArray[top]);
                return true;
            }
            else
            {
                Console.WriteLine("i cant");
                return false;
            }

        }
        bool pick()
        {
            if(!isfull())
            {
                Console.WriteLine("table is empty");
                return false;

            }
            else
            {
                Console.WriteLine(StckArray[top]);
                return true;
            }

        }   


    }
}
