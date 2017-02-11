using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalculatorKata
{
    public class RPNCalculator
    {
        public string Evaluate(string input)
        {
            string[] items = input.Split(' ');
            int operationResult = 0;
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < items.Length; i++)
            {
                if (IsOperator(items[i]))
                {
                    operationResult = ProcessOperation(items[i], stack);
                    stack.Push(operationResult);
                }
                else
                {
                    stack.Push(int.Parse(items[i]));
                }                
            }

            return CalculateFinalResult(stack);
        }

        private int ProcessOperation(string item, Stack<int> stack)
        {
            int result = 0;
            int secondOperand = stack.Pop();
            int firstOperand = stack.Pop();            

            if (item == "+")
            {
                result = firstOperand + secondOperand;
            }
            if (item == "-")
            {
                result = firstOperand - secondOperand;
            }
            if (item == "*")
            {
                result = firstOperand * secondOperand;
            }
            if (item == "/")
            {
                result = firstOperand / secondOperand;
            }

            return result;
        }

        private bool IsOperator(string item)
        {
            return item == "+" || item == "-" || item == "*" || item == "/";
        }

        private string CalculateFinalResult(Stack<int> stack)
        {
            string result = "";

            while (stack.Count > 0)
            {
                result = stack.Pop().ToString() + " " + result;
            }

            return result.TrimEnd();
        }
    }
}
