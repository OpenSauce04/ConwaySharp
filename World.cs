namespace ConwaySharp
{
	class World
	{
		public static int[,] Array = new int[50,50];
		public static void Init()
		{
			for (int y = 0; y < 50; y++)
			{
				for (int x = 0; x < 50; x++)
				{
					World.Array[x,y] = 1;
				}
			}
		}
	}
}