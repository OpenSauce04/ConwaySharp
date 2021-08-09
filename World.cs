namespace ConwaySharp
{
	class World
	{
		public static int[,] Array = new int[52, 52]; // One layer of padding in all directions
		public static int[,] Colourmap = new int[52, 52]; // Used for calculating cell colour: 0=normal, 1=dead, 2=new
		public static void Init()
		{
			for (int y = 1; y <= 50; y++)
			{
				for (int x = 1; x <= 50; x++)
				{
					GenerateChecker(x, y);
				}
			}
		}
		public static void Simulate()
		{


			for (int y = 1; y <= 50; y++)
			{
				for (int x = 1; x <= 50; x++)
				{
					World.Colourmap[x, y] = 0;
					int neighbors = GetNeighborCount(x, y);
					if (World.Array[x, y] == 1)
					{
						if (neighbors < 2 || neighbors > 3) // Die from under/ over population
						{
							World.Array[x, y] = 0;
							World.Colourmap[x, y] = 1;
						}
					}
					else
					{
						if (neighbors == 3)
						{
							World.Array[x, y] = 1;
							World.Colourmap[x, y] = 2;
						}
					}
				}
			}
		}
		private static int GetNeighborCount(int x, int y)
		{
			return
				World.Array[x - 1, y - 1] +
				World.Array[x    , y - 1] +
				World.Array[x + 1, y - 1] +
				World.Array[x - 1, y    ] +
				World.Array[x + 1, y    ] +
				World.Array[x - 1, y + 1] +
				World.Array[x, y + 1    ] +
				World.Array[x + 1, y + 1];
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