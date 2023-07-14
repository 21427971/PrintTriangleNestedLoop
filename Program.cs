using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTriangleNestedLoop
{
    class Program
    {//Msimango KSI
        static void Main(string[] args)
        {//C#.Net program to print a triangle with a number of lines
            int Row, Column, Num;
            Console.Write("Enter a number : ");
            Num = int.Parse(Console.ReadLine());
            for (Row = 1; Row <= Num; Row++)
            {// First loop to go through the line
                for(Column=1;Column<=Row;Column=Column+1)
                {//Go through the culumns of a current line
                    Console.Write("|"+Column);
                }
                Console.WriteLine();
            }               
        }
    }
}
