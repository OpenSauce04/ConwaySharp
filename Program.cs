using System;
using System.Threading;
namespace ConwaySharp
{
	class Program
	{
		private static void Init()
		{
			Console.CursorVisible = false;
			World.Init();
			Resize.Disable();
			Console.SetWindowSize(102, 52);
			Display.DrawBorder();
		}
		static void Main(string[] args)
		{
			Program.Init();


			for (; ; )
			{
				Display.Draw();
				Thread.Sleep(16);
			}
		}
	}
}
