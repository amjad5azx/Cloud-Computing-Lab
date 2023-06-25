using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;
using System.Collections.Generic;

namespace WorkflowConsoleApplicationCalculator
{

    class Program
    {
        static void Main(string[] args)
        {

            Workflow1 workflow = new Workflow1();
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operation:");
            string operation = Console.ReadLine();


            workflow.Num1 = num1;
            workflow.Num2 = num2;
            workflow.Operation = operation;

            IDictionary<string, object> result = WorkflowInvoker.Invoke(workflow);

            Console.WriteLine("Result: " + result["Result"]);
        }
    }
}
