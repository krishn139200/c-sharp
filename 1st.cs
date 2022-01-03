using System;
					
public class Program
{
	public static void Main(string[] args)
	{
		Console.WriteLine("enter the any a number in (10,20,30)");
		int num=Convert.ToInt32(Console.ReadLine());
		
		switch(num)
		{
			case 10:
				Console.WriteLine("you entered 10");
				break;
			case 20:
				Console.WriteLine("you entered 20");
				break;
			case 30:
				Console.WriteLine("you entered 30");
				break;
			default:
				Console.WriteLine("you are not entered expacted number try again!");
				break;
		}
	}
}
