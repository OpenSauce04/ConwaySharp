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
			for (int y = 1; y <= 50; y++)
			{
				Console.CursorLeft = 1;
				Console.CursorTop++;
				for (int x = 1; x <= 50; x++)
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
			switch(World.Colourmap[x, y])
			{
				case 1:
					buffer += "\u001b[38;5;235m"; // Cell has died, make cell dark grey
					break;
				case 2:
					buffer += "\u001b[38;5;255m"; // A new cell is born, make cell white
					break;
				default:
					if (World.Array[x, y] == 0)
					{
						buffer += "\u001b[30m"; // There is no cell here, make cell black
					}
					else
					{                    
						buffer += "\u001b[38;5;247m"; // There is a cell here that hasn't changed, make cell grey
					}
					break;
			}
			buffer += "██";

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
