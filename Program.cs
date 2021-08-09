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
			Window.DisableResize();
			Window.EnableANSIColour();
			Console.SetWindowSize(103, 53);
			Console.SetBufferSize(103, 53);
			Display.DrawBorder();
		}
		static void Main(string[] args)
		{
			Program.Init();


			for (; ; )
			{
				Display.Draw();
				World.Simulate();
				Thread.Sleep(50);
				
			}
		}
	}
}
