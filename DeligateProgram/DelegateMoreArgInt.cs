using System;

namespace DelegateMoreArgInt
{
    class Program
    {
        public delegate int Calculator(int firstNumber, int secondNumber);

        static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
       
        static void Main(string[] args)
        {

            var add = new Calculator(Add);
            int sum = add.Invoke(5, 10);
            Console.WriteLine(sum);
  
        }
    }
}
