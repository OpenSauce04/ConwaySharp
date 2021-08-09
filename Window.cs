using System;
using System.Runtime.InteropServices;
namespace ConwaySharp
{
	public class Window
	{
		private const int MF_BYCOMMAND = 0x00000000;
		public const int SC_CLOSE = 0xF060;
		public const int SC_MINIMIZE = 0xF020;
		public const int SC_MAXIMIZE = 0xF030;
		public const int SC_SIZE = 0xF000;

		[DllImport("user32.dll")]
		public static extern int DeleteMenu(IntPtr hMenu, int nPosition, int wFlags);

		[DllImport("user32.dll")]
		private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

		[DllImport("kernel32.dll", ExactSpelling = true)]
		private static extern IntPtr GetConsoleWindow();


		public static void DisableResize()
		{
			IntPtr handle = GetConsoleWindow();
			IntPtr sysMenu = GetSystemMenu(handle, false);

			if (handle != IntPtr.Zero)
			{
				DeleteMenu(sysMenu, SC_MAXIMIZE, MF_BYCOMMAND);
				DeleteMenu(sysMenu, SC_SIZE, MF_BYCOMMAND);
			}
		}

		// --------------------------------------------------------------------------

		private const int STD_OUTPUT_HANDLE = -11;
		private const uint ENABLE_VIRTUAL_TERMINAL_PROCESSING = 0x0004;
		private const uint DISABLE_NEWLINE_AUTO_RETURN = 0x0008;

		[DllImport("kernel32.dll")]
		private static extern bool GetConsoleMode(IntPtr hConsoleHandle, out uint lpMode);

		[DllImport("kernel32.dll")]
		private static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);

		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr GetStdHandle(int nStdHandle);

		[DllImport("kernel32.dll")]
		public static extern uint GetLastError();
		public static void EnableANSIColour()
		{
			var iStdOut = GetStdHandle(STD_OUTPUT_HANDLE);
			if (!GetConsoleMode(iStdOut, out uint outConsoleMode))
			{
				Console.WriteLine("failed to get output console mode");
				Console.ReadKey();
				return;
			}

			outConsoleMode |= ENABLE_VIRTUAL_TERMINAL_PROCESSING | DISABLE_NEWLINE_AUTO_RETURN;
			if (!SetConsoleMode(iStdOut, outConsoleMode))
			{
				Console.WriteLine($"failed to set output console mode, error code: {GetLastError()}");
				Console.ReadKey();
				return;
			}
		}
	}
}
