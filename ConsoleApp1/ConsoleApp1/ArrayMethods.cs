using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ArrayMethods
    {
        private Object[] _privatearr;

        public ArrayMethods(Object[] aObjArray)
        {
            _privatearr = aObjArray;
        }
        public Object[] PrivateArr {
            get { return _privatearr; }
            set { _privatearr = value; }
        }

        public static void Log(Object[] ObjArray)
        {
            //standard for loop for array
            for(int i = 0; i<ObjArray.Length; i++)
            {
                Console.WriteLine(ObjArray[i]);
            }
        }
    }
}
