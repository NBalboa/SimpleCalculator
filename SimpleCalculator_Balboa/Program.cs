using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator_Balboa
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;
            string output = "";
            string tryAgain = "";
            bool isContinue = true;

            do
            {
                bool flag = true;
                Console.WriteLine("Welcome to Simple Calculator\n");

                firstNumber = GetInt("Enter First Number: ");
                secondNumber = GetInt("Enter Second Number: ");

                output = GetInfoFromConsole(firstNumber, secondNumber);
                Console.WriteLine(output);


                tryAgain = GetString("Do you want to try again(Y/N): ");

                while (flag)
                {
                    if (tryAgain.ToLower() == "y")
                    {
                        flag = false;
                        Console.Clear();
                    }
                    else if (tryAgain.ToLower() == "n")
                    {
                        flag = false;
                        isContinue = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                        tryAgain = GetString("Do you want to try again(Y/N): ");
                    }
                }

            } while (isContinue);


            Console.WriteLine("End of the Program");
        }
        public static int GetInt(string message)
        {
            string numberText = GetString(message);
            int number;
            bool isValidNumber = int.TryParse(numberText, out number);

            while (!isValidNumber)
            {
                Console.WriteLine("Invalid input. Please enter a digit");
                numberText = GetString(message);
                isValidNumber = int.TryParse(numberText, out number);
            }

            return number;
        }
        public static string GetString(string message)
        {
            string output = "";
            while (string.IsNullOrEmpty(output))
            {
                Console.Write(message);
                output = Console.ReadLine();
            }

            return output;
        }
        public static void ShowUI()
        {
            Console.WriteLine("Simple Calculator:");
            Console.WriteLine("[1] Addition");
            Console.WriteLine("[2] Subtraction");
            Console.WriteLine("[3] Multiplication");
            Console.WriteLine("[4] Division");
        }

        public static string GetInfoFromConsole(int firstNumber, int secondNumber)
        {
            int result = 0;
            string output = "";
            string select = "";
            bool flag = true;
           
            Operation calculate = new Operation();

            
            ShowUI();

            while (flag)
            {
                select = GetString("Select Computation: ");

                if (select == "1")
                {
                    result = calculate.Addition(firstNumber, secondNumber);
                    output = $"{firstNumber} + {secondNumber} = {result}";
                    flag = false;
                }
                else if (select == "2")
                {
                    result = calculate.Subtraction(firstNumber, secondNumber);
                    output = $"{firstNumber} - {secondNumber} = {result}";
                    flag = false;
                }
                else if (select == "3")
                {
                    result = calculate.Multiplication(firstNumber, secondNumber);
                    output = $"{firstNumber} * {secondNumber} = {result}";
                    flag = false;
                }
                else if (select == "4")
                {
                    result = calculate.Division(firstNumber, secondNumber);
                    output = $"{firstNumber} / {secondNumber} = {result}";
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Invalid Input.");
                } 
            }

            return output;
        }
    }
}
