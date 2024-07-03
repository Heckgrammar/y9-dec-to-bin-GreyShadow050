using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y9_DEC_TO_BIN_SKELETON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your denary number");
            int denary=Convert.ToInt32(Console.ReadLine());
            int[] binary = new int[8];
            for (int i = 0; denary > 0; i++)
            {
                binary[i] = denary % 2;
                denary= denary / 2;
            }
            int step = binary.Length -1;
            for (int i = step; i >= 0; i--)
            {   
                Console.Write(binary[i]);
            }
            Console.Write("");
        }
    }
}