using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Consoler
    {
        public int PublicVariable;
        private string _getSetMethods;
        private int PrivateVariable;

        //Class constructor without arguments

        public Consoler()
        {
            PublicVariable = 0;
            PrivateVariable = 0;
        }

        //Class constructor with arguments
        public Consoler(int aPublic, int aPrivate)
        {
            PublicVariable = aPublic;
            PrivateVariable = aPrivate;
        }

        //Just a console log
        public static void ConsoleLog()
        {
            Console.WriteLine("method 1");
        }

        //C# most used way of getter and setters (auto properties) returns/sets a string

        //public string GetSetMethods { get; set; }

        public string GetSetMethods
        {
            get { return _getSetMethods; }
            set { _getSetMethods = value; }
        }

        //Java set/get way
        public int GetPrivateVariable()
        {
            return PrivateVariable;
        }

        public void SetPrivateVariable(int value)
        {
            PrivateVariable = value;
        }

    }
}