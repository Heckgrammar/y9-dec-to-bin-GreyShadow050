﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y9_DEC_TO_BIN_SKELETON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STARTER: Practice using breakpoints and the watch window (F8 to single-step, F11 to start in single step mode)
            int myInt = 0; //just for testing single stepping
            string myString = "12"; //watch me being cast from string to int
            int myStringAsInt = Convert.ToInt32(myString); //watch me cast from string to int

            //MAIN:  NUMBER CONVERSION PROGRAM
            Console.WriteLine(numberConversion(926,2));
            string stringS = numberConversion(926, 2);
            //CODE GOES HERE
            Console.WriteLine(StringInString("I want"," a lot of food"));
        }

        //static void means the function will not return a value so it does not need a data type 
        //...this function DOES return a value so the method must have a data type
        static string numberConversion(int number, int numberbase)
        {
            //CODE GOES HERE
            string result= Convert.ToString(number+numberbase);
            return result; //REMOVE THE RED LINE!   
        }

        static string StringInString(string string1, string string2)
        {
            string result = string1 + string2;
            return result;
        }
    }
}
