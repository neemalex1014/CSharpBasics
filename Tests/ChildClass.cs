using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.Tests
{
    public class ChildClass
    {
        //AddTwoNumbers is user created method with no return value and parameters
        public void AddTwoNumbers()
        {
            int num1 = 10;
            int num2 = 20;
            int result = num1 + num2;
            Console.WriteLine("This method adds two numbers with no return type : ");
            Console.WriteLine(result);
        }
  
        //AddTwoNumbersWithReturnType is user created method with return value and parameters
        public int AddTwoNumbersWithReturnType(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("This method adds two value with return type : ");
            return result;
        }
    }
}
