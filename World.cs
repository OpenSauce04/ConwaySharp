namespace ConwaySharp
{
	class World
	{
		public static int[,] Array = new int[50, 50];
		public static void Init()
		{
			for (int y = 0; y < 50; y++)
			{
				for (int x = 0; x < 50; x++)
				{
					GenerateChecker(x, y);
				}
			}
		}

		private static void GenerateChecker(int x, int y) // I know this code is terrible, but I was just testing stuff
		{
			if (x % 2 == 1)
			{
				if (y % 2 == 1)
				{
					World.Array[x, y] = 0;
				}
				else
				{
					World.Array[x, y] = 1;
				}
			}
			else
			{
				if (y % 2 == 1)
				{
					World.Array[x, y] = 1;
				}
				else
				{
					World.Array[x, y] = 0;
				}
			}
		}
	}
}