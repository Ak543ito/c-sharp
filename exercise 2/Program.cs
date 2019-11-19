using System;

namespace exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string op;
            int number1 = 0;
            int number2 = 0;
            int result = 0;
            
            Console.WriteLine("Choose your operator:    ");
            op = Console.ReadLine();
            Console.WriteLine("Choose your first number:    ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose your second number:    ");
            number2 = Convert.ToInt32(Console.ReadLine());

            if(op == "/" ){
                result = number1 / number2;
            }
            if(op == "+" ){
                result = number1 + number2;
            }
            if(op == "-" ){
                result = number1 - number2;
            }
            if(op == "*" ){
                result = number1 * number2;
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
