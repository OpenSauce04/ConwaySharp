using System;

namespace ConwaySharp
{
	partial class Program
	{
		private static void IntroText()
		{
			Console.Write("\r\n  This program is a C# .net core 3.1 implementation of John Conway's famous \"Game of Life\" simulation.\r\n" +
						  "  In this simulation, there is a 50x50 grid which is populated with cells which can either be dead or \r\nalive.\r\n\n" +
						  "  The rules go as follows:\r\n" +

						  "  - Any living cell with fewer than two live neighbours dies, as if by underpopulation.\r\n" +
						  "  - Any living cell with two or three live neighbours lives on to the next generation.\r\n" +
						  "  - Any living cell with more than three live neighbours dies, as if by overpopulation.\r\n" +
						  "  - Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.\r\n\n" +

						  "  In this implementation, the status of the individual cells are colour-coded as follows:\r\n" +
						  "  Dead cells are represented by the colour Black\r\n" +
						  "  Alive cells are represented by the colour Grey \u001b[48;5;247m  \u001b[0m\r\n" +
						  "  Newly born cells are represented by the colour White \u001b[48;5;255m  \u001b[0m\r\n" +
						  "  Cells that have just died are represented by the colour Dark Grey \u001b[48;5;235m  \u001b[0m\r\n\n" +

						  "  A checkerboard pattern is used as a starting point in this implementation.\r\n\n" +

						  "                              PRESS ANY KEY TO START\r\n\n\n\n\n\n"+

						  "  Delay between frames: "+displayDelay+"ms");
			Console.CursorLeft = 101;
			Console.CursorTop = 52;
			Console.Write("DB");
			Console.ReadKey();
		}
	}
}
