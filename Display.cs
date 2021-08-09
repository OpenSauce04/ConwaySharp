using System;

namespace ConwaySharp
{
	class Display
	{
		private static string buffer;
		public static void Reset()
		{
			Console.CursorLeft = 0;
			Console.CursorTop = 0;
		}

		public static void Draw()
		{
			Display.Reset();
			for (int y = 0; y < 50; y++)
			{
				Console.CursorLeft = 1;
				Console.CursorTop++;
				for (int x = 0; x < 50; x++)
				{
					CalculateChar(x, y);
				}
				Console.Write(buffer);
				buffer = "";
				
			}
			Console.Write(Display.buffer);
		}

		private static void CalculateChar(int x, int y)
		{
			if (World.Array[x, y] == 1)
			{
				buffer += "██";
			}
			else
			{
				buffer += "  ";
			}
		}
		public static void DrawBorder()
		{
			Display.Reset();
			Console.WriteLine("╔" + new String('═', 100) + "╗");
			for (int x = 0; x < 50; x++)
			{
				Console.WriteLine("║" + new String(' ', 100) + "║");
			}
			Console.WriteLine("╚" + new String('═', 100) + "╝");

		}
	}
}
