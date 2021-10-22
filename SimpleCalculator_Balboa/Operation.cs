namespace SimpleCalculator_Balboa
{
    public class Operation
    {
        public int Addition(int firstNumber, int secondNumber)
        {
            int output = firstNumber + secondNumber;
            return output;
        }
        public int Subtraction(int numberOne, int numberTwo)
        {
            int output = numberOne - numberTwo;
            return output;
        }
        public int Multiplication(int numberOne, int numberTwo)
        {
            int output = numberOne * numberTwo;
            return output;
        }
        public int Division(int numberOne, int numberTwo)
        {
            int output = numberOne / numberTwo;
            return output;
        }
    }
}