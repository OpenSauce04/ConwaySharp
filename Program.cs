using System;
using System.Threading;
namespace ConwaySharp
{
	partial class Program
	{
		static int displayDelay = 50;
		private static void Init()
		{
			Console.CursorVisible = false;
			World.Init();
			Window.DisableResize();
			Window.EnableANSIColour();
			Console.SetWindowSize(103, 53);
			Console.SetBufferSize(103, 53);
		}
		static void Main(string[] args)
		{
			Program.Init();
			IntroText();
			Display.DrawBorder();
			for (; ; )
			{
				Display.Draw();
				World.Simulate();
				Thread.Sleep(displayDelay);

			}
		}
	}
}
