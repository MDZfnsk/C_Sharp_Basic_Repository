//Program.cs

using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            EncapClass ec = new EncapClass();

            Console.Write(" Enter 1st Number :-");
            ec.setNum1(int.Parse(Console.ReadLine()));
            Console.Write(" Enter 2nd Number :-");
            ec.setNum2(int.Parse(Console.ReadLine()));

            Console.WriteLine("The Summation of Two Numbers Are :- " + (ec.getNum1() + ec.getNum2()));
            Console.ReadKey();
        }
    }
}


/*
EncapClass.cs
using System;
using System.Collections.Generic;
using System.Text; 
*/

namespace ConsoleApp1
{
    class EncapClass
    {
        private int num1,num2;
        public void setNum1(int UserNum1)
        {
            num1 = UserNum1;
        }
        public int getNum1()
        {
            return num1;
        }

        public void setNum2(int UserNum2)
        {
            num2 = UserNum2;
        }
        public int getNum2()
        {
            return num2;
        }
    }
}



/* 
The above code set are from two different classes. Program.cs and Encapclass.cs . Program.cs is the main class and in order tis code set to work I have created
an encapsulated class named Encapclass.cs and I've declared relavant getters and setters inside that class. Whenever executing, use two code sets in deferent classes.
Class names have been commented out in the above code.
*/
