using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//каждое должно быть в своем пространстве
namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.ForegroundColor = System.ConsoleColor.Green;
			Console.Title = "Hello C#";
			Console.WindowHeight = 10;
			Console.WindowWidth = 50;
			Console.BufferWidth = 50;
			Console.BufferHeight = 10;
			Console.CursorSize = 100;
			#region Strings
			Console.Write("Привет мир\n");
			Console.WriteLine("сам привет");
			string name;
			string age;
			Console.Write("Введите ваше имя: ");
			name = Console.ReadLine();
			Console.Write("сколько вам лет? ");
			age = Console.ReadLine();
			//контанация строк:
			Console.WriteLine("Привет " + name + ", тебе " + age + " лет.");
			//форматирование строк:
			Console.WriteLine("Привет {0}, тебе {1} лет", name, age);
			//интерполяция строк:
			Console.WriteLine($"Привет {name}, тебе {age} let");
			Console.WriteLine(@"C:\Windows\System32\");
			#endregion
			//System.Console.Clear();
			
		}
    }
}
