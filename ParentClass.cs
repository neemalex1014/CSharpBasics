using CSharpBasics.Tests;
using static System.Formats.Asn1.AsnWriter;

// create a sample code for c# with class, methods, variables and objects
namespace CSharpBasics
{   
    //class is created
    internal class ParentClass
    {
        //Initialising and declaring variables at class level, Scope till end of the program
        String name = "Neema";
        static int number = 1234;
        Boolean TrueOrFalse = true;

        //main is a method, we can create one or more method in a class
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");

            // ClassName ObjName = new ClassName();
            ChildClass ChildClassObject = new ChildClass();
            ChildClass2 ChildClassObject2 = new ChildClass2();

            //Initialising and declaring variables at method level, Scope till end of the method
            int number1 = 20;
            Console.WriteLine(number1);

            //AddTwoNumbers is user created method with no return value and parameter
            ChildClassObject.AddTwoNumbers();

            //AddTwoNumbersWithReturnType is user created method with return value and parameters
            int result = ChildClassObject.AddTwoNumbersWithReturnType(30,40);
            Console.WriteLine(result);

            ChildClassObject2.MethodWithReturnTypeString();
        }

        

    }
}

