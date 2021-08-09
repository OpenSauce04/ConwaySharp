using System;
using System.Threading;
namespace ConwaySharp
{
	class Program
	{
		static void Main(string[] args)
		{
			World.Init();
			for (; ; )
			{
				Display.Draw();
				Thread.Sleep(16);
			}
		}
	}
}
