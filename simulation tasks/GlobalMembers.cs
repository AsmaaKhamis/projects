using System;

internal static class DefineConstants
{
    public const string FILENAME = "ssq1.dat"; // input data file
    public const double START = 0.0;
}
public static class GlobalMembers
{
	
	   public static double GetArrival(FILE fp) // read an arrival time
	   {
	  double a;

	  fscanf(fp, "%lf", a);
	  return (a);
	   }

	
	   public static double GetService(FILE fp) // read a service time
       {
	  double s;

	  fscanf(fp, "%lf\n", s);
	  return (s);
	   }

	
	   static int Main()
	
	   {
	  FILE fp; // input data file
	  int index = 0; // job index
	  double arrival = DefineConstants.START; // arrival time
	  double delay; // delay in queue
	  double service; // service time
	  double wait; // delay + service
	  double departure = DefineConstants.START; // departure time

	  fp = fopen(DefineConstants.FILENAME, "r");
	  if (fp == null)
	  {
		Console.Error.Write("Cannot open input file {0}\n", DefineConstants.FILENAME);
		return (1);
	  }

	  while (!feof(fp))
	  {
		index++;
		arrival = GetArrival(fp);
		if (arrival < departure)
		{
		  delay = departure - arrival; // delay in queue
		}
		else
		{
		  delay = 0.0; // no delay
		}
		service = GetService(fp);
		wait = delay + service;
		departure = arrival + wait; // time of departure
		Console.Write("{0:D}\t {1:f}\n",index, delay);


	  }

	  fclose(fp);
	  return (0);
	   }


}