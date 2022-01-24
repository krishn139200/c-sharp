using System;
	// method of overloding by changing number of arguments
	public class cal
	{
		public static int add (int a,int b)
		{
			return a+b;		
		}
		public static int add (int a,int b,int c)
		{
			return a+b+c;
		}
	}
	// method of overloding by changing data type of arguments
	public class cal_new
	{
		public static int add (int a,int b)
		{
			return a+b;	
		}
		public static float add (float a,float b)
		{
			return a+b;
		}
	}
	public class testoverloding
	{
		public static void Main (string[] args)
		{
			//test method changing number of arguments
			Console.WriteLine(cal.add(11,15));
			Console.WriteLine(cal.add(11,15,16));
			//test method changing data type of arguments
			Console.WriteLine(cal_new.add(11,21));
			Console.WriteLine(cal_new.add(11.1f,21.4f));
			
			
		}
	}
