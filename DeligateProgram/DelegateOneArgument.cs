using System;

namespace DelegateOneArgument
{
    class Program
    {
        public delegate void DelegateName(string name);

        static void PrintName(string name)
        {

            Console.WriteLine(name);
        }

        static void Main(string[] args)
        {
            var delegateObj = new DelegateName(PrintName);

            delegateObj.Invoke("glory");


        }
    }

}
