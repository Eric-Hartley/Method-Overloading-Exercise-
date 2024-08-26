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
            else if (isChecked == true && answer < 1 && answer > -1)
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
            // Integer values
            var int1 = 5;
            var int2 = 2;

            // Double values
            var double1 = 1.5;
            var double2 = 3.8;

            // Checked
            bool isChecked = true;

            // Adding each type together
            var addInts = Add(int1, int2, isChecked);
            var addDoubles = Add(double1, double2);


            Console.WriteLine(addInts);
            Console.WriteLine(addDoubles);
        }
    }
}
