using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {   
            /*
             * Class and Variable definitions practice
             */

            Console.WriteLine("Hello World!");
            Consoler.ConsoleLog();
            Consoler myConsole = new Consoler(10, 10);
            myConsole.GetSetMethods = "hello";
            Console.WriteLine($"getsetmethods : {myConsole.GetSetMethods}");
            myConsole.GetSetMethods = Console.ReadLine();
            Console.WriteLine($"getsetmethods : {myConsole.GetSetMethods}");
            Console.WriteLine($"private var : {myConsole.GetPrivateVariable()}");
            Console.WriteLine($"public var : {myConsole.PublicVariable}");

            /*
             * Array declaration and navigation practice
             */

            Object[] array;
            array = new Object[]{ 2340.0, 4523.69, 3421.0 };
            ArrayMethods myArrayMethods = new ArrayMethods(array);
            ArrayMethods.Log(myArrayMethods.PrivateArr);
            ArrayMethods myArrayMethods2 = new ArrayMethods(new Object[]{ "hello", "number", 3421.0 });
            ArrayMethods.Log(myArrayMethods2.PrivateArr);
        }
    }
}
