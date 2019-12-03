using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите выражение: ");
            string expression = Console.ReadLine();
            Console.WriteLine(expression);
            double a = Convert.ToDouble(expression.Split("+-*/".ToCharArray())[0]);
            double b = Convert.ToDouble(expression.Split("+-*/".ToCharArray())[1]);
            if(expression.Contains('+'))
            {
                Console.WriteLine(expression + " = " + (a + b));
                Console.WriteLine($"{expression} = {a + b}");
            }else(expression.Contains('+'))
            {
                Console.WriteLine(expression + " = " + (a + b));
                Console.WriteLine($"{expression} = {a + b}");
            }if(expression.Contains('+'))
            {
                Console.WriteLine(expression + " = " + (a + b));
                Console.WriteLine($"{expression} = {a + b}");
            }if(expression.Contains('+'))
            {
                Console.WriteLine(expression + " = " + (a + b));
                Console.WriteLine($"{expression} = {a + b}");
            }
            
                    
        }
    }
}
