using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите ваше имя: ");
			string name = Console.ReadLine();
			Console.Title = "Player -" + name;

			Console.WriteLine("Выберите цвет игрока: ");
			ConsoleColor[] colors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
			for(int i = 0; i < colors.Length;i++)
			{
				Console.ForegroundColor = colors[i];
				Console.WriteLine(i + "\t" + colors[i]);
			}

			Console.ForegroundColor = colors [Console.Read()- 48];

			int xSize = 100;
			int ySize = 30;
			Console.SetWindowSize(xSize, ySize);
			Console.SetBufferSize(xSize, ySize);
			ConsoleKey key;
				int x = 15;
				int y = 15;
			do
			{
				key = Console.ReadKey(true).Key;
				
				//Console.WriteLine("\t"+(int)key);
				switch (key)
				{
					#region Shooter
					//case ConsoleKey.W: Console.WriteLine("Вперед");break;
					//case ConsoleKey.S: Console.WriteLine("Назад");break;
					//case ConsoleKey.A: Console.WriteLine("Лево");break;
					//case ConsoleKey.D: Console.WriteLine("Право");break;
					//case ConsoleKey.Escape: Console.WriteLine("Выход");break;
					//default:Console.WriteLine("ERROR");break;
					#endregion
					case ConsoleKey.W: if(y>0)y--; break;
					case ConsoleKey.S: if(y<ySize - 1)y++; break;
					case ConsoleKey.A: if(x>0)x--; break;
					case ConsoleKey.D: if(x<xSize - 1)x++; break;
				}
				
				Console.SetCursorPosition(x, y);
				Console.WriteLine((char)2);
			} while (key != ConsoleKey.Escape); 
		}
	}
}
