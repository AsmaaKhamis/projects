using System;

public static class GlobalMembers
{
	

	static int Main()
	{
		int interval;
		int i;
		double rand_x;
		double rand_y;
		double origin_dist;
		double pi;
		int circle_points = 0;
		int square_points = 0;

		RandomNumbers.Seed(time(null)); //Initializing rand()

		for (i = 0; i < (DefineConstants.INTERVAL * DefineConstants.INTERVAL); i++) //Total Random numbers generated = possible x values * possible y values
		{

			rand_x = (double)(RandomNumbers.NextNumber() % (DefineConstants.INTERVAL + 1)) / DefineConstants.INTERVAL; //x value randomly generated
			rand_y = (double)(RandomNumbers.NextNumber() % (DefineConstants.INTERVAL + 1)) / DefineConstants.INTERVAL; //y value randomly generated

			origin_dist = rand_x * rand_x + rand_y * rand_y; //Distance between (x,y) from the origin

			if (origin_dist <= 1)
			{
				circle_points++; //Checking if (x,y) lies inside the define circle with R=1
			}
			square_points++; //Total number of points generated

			pi = (double)(4 * circle_points) / square_points; //estimated pi after this iteration

			Console.Write(rand_x);
			Console.Write(" ");
			Console.Write(rand_y);
			Console.Write(" ");
			Console.Write(circle_points);
			Console.Write(" ");
			Console.Write(square_points);
			Console.Write(" - ");
			Console.Write(pi);
			Console.Write("\n");
			Console.Write("\n");

			if (i < 10)
			{
				Console.ReadKey(true); //Pausing estimation for first 10 values (Optional)
			}
		}

		Console.Write("\nFinal Estimation of Pi = ");
		Console.Write(pi);

		return 0;
	} 

	


internal static class DefineConstants
{
	public const int INTERVAL = 5; //Defines precision for x and y values. More the interval, more the number of significant digits
}
internal static class RandomNumbers
{
	private static System.Random r;

	public static int NextNumber()
	{
		if (r == null)
			Seed();

		return r.Next();
	}

	public static int NextNumber(int ceiling)
	{
		if (r == null)
			Seed();

		return r.Next(ceiling);
	}

	public static void Seed()
	{
		r = new System.Random();
	}

	public static void Seed(int seed)
	{
		r = new System.Random(seed);
	}
}