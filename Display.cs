using System;

namespace ConwaySharp
{
	class Display
	{
		private static string buffer;
		public static void Clear()
		{
			Console.CursorLeft = 0;
			Console.CursorTop = 0;
			buffer = "";
		}

		public static void Draw()
		{
			Display.Clear();
			
			for (int y = 0; y < 50; y++)
			{
				for (int x = 0; x < 50; x++)
				{
					if (World.Array[x, y] == 1)
					{
						buffer+="@";
					}
				}
				buffer+='\n';
			}
			Console.Write(Display.buffer);
		}
	}
}
