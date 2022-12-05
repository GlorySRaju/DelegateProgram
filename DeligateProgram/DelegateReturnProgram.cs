using System;

namespace DeligateReturnProgram
{
    class Program
    {
        public delegate string DelegateName();
        static string Name { get; set; }
        
        static string PrintName()
        {
            return Name="glory";
        }
        
        static void Main(string[] args)
        {
            var delegateObj = new DelegateName(PrintName);
            string name=delegateObj.Invoke();

            Console.WriteLine(name);
        }
    }
}
