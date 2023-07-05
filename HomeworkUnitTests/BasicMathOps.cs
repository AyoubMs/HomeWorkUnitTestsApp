using System;

namespace HomeworkUnitTests
{
    public class BasicMathOps
    {
        public int CalculateInts(int a, int b, string operation)
        {
            switch (operation)
            {
                case "*":
                    return a * b;
                case "/":
                    return a / b;
                case "-":
                    return a - b;
                case "+":
                    return a + b;
                default:
                    return 0;
            }
        }
    }
}
