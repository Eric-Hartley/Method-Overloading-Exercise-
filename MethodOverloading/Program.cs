using System.Diagnostics.CodeAnalysis;

namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int number1, int number2)
        {
            return number1 + number2;

        }
        public static double Add(double number1, double number2)
        {
            return number1 + number2;

        }
        public static string Add(int number1, int number2, bool isChecked)
        {
            var answer = number1 + number2;
            if (isChecked == true && answer > 1)
            {
                return $"{answer} dollars";
            }
            else if (isChecked == true && answer == 1 || answer == -1)
            {
                return answer + " dollar";
            }
            else if (isChecked == true && answer < 1 & answer > -1)
            {
                return $"{answer} dollars";
            }
            else if (isChecked == true && answer < -1)
            {
                return $"{answer} dollars";
            }
            else
            {
                return answer.ToString();
            }
        }
            
            
            

        
        static void Main(string[] args)
        {
            //Change the values here
            var number1 = 0;
            var number2 = 0;
            bool isChecked = false;
            // ----------------

            var answer = Add(number1, number2, isChecked);
            Console.WriteLine(answer);
        }
    }
}
