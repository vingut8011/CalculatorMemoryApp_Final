// Author: Vincent Y. Gutierrez
// Phase 4 - Basic arithmetic operations

namespace CalculatorMemoryApp_Final
{
    public static class Calculator
    {
        public static int Add(int a, int b) => a + b;
        public static int Subtract(int a, int b) => a - b;
        public static int Multiply(int a, int b) => a * b;

        public static bool TryDivide(int a, int b, out double result)
        {
            if (b == 0)
            {
                result = 0;
                return false;
            }

            result = (double)a / b;
            return true;
        }
    }
}

