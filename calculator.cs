//dotnet "C:\Users\user\AppData\Roaming\Code\User\cs-script.user\dotnet\cscs.dll"  "c:\Users\user\OneDrive\Desktop\c sharp\calculator.cs"
using System;

namespace ProjectCs
{
    class ProjectCs 
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+") {
                Console.Write( num1 + num2);
            }
            else if (op == "-") {
                Console.Write( num1 - num2);
            }
            else if (op == "*") {
                Console.Write( num1 * num2);
            }
            else if (op == "/") {
                Console.Write( num1 / num2);
            }
            else {
                Console.Write("Invalid Operator");
            }
        }
    }
}