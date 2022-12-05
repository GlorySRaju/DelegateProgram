using System;

namespace DelegateTwoArgument
{
    class Program
    {
        public delegate void DelegateName(string firstName,string secondName );

        static void PrintName(string firstName,string secondName)
        {

            Console.WriteLine(firstName,secondName);
        }

        static void Main(string[] args)
        {
            var delegateObj = new DelegateName(PrintName);

            delegateObj.Invoke("glory","susan_raju");

        }
    }
}
