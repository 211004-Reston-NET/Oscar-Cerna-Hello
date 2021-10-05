using System;
using HouseFunction;   

//This is a comment  

/*
    This is mutliline comment 
    - We use PascelCase for naming Class in C# (every word Captialized)
    - We use camelCase for naming fields  
*/

namespace HelloWorld
{
    class Program
    {
        /*
            - Main method is the first method that will be called/run. (The compiler will look for this method)
            - static, I don't have to instantiate the program class to use that method 
            - void, the method will not return any type 
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Program.Example();

            House Oscar = new House();

            Oscar.MiceName = "Jerry";
            Oscar.Owner = "Stephen";
            Console.WriteLine(Oscar.MiceName);
            Console.WriteLine(Oscar.Owner);
            Console.WriteLine(Oscar.owner);

            string name;
            Console.WriteLine("Please enter your name");

            name = Console.ReadLine();
            Console.WriteLine("Welcome", name);
        }
    }
}
