using System;
	public class Employee
	{
		private static int counter;
		
		public Employee()
		{
			counter++;
		}
		public static int Counter
		{
			get
			{
				return counter;
			}
		}
		public static void Main(string[] args)
		{
			Employee e1 = new Employee();
			Employee e2 = new Employee();
			Employee e3 = new Employee();
			Console.WriteLine("No. of employee: " + Employee.Counter);
		}
	}
