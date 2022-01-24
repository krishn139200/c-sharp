using System;
	public class EnumExample
	{
		public enum Days { sun, mon, tue, wed, thu, fri, sat };
		
		public static void Main()
		{
			
			foreach (string d in Enum.GetNames(typeof(Days)))
			{
					Console.WriteLine(d);
			}
		}
	}	
