using System;
	public class animal
	{
		public string color="white";
	}
	public class dog:animal
	{
		public string color="black";
		public void show_color()
		{
			Console.WriteLine(base.color);
			Console.WriteLine(color);
		}
		public static void Main(string[] args)
		{
			dog d1 = new dog();
			d1.show_color();
		}
	}
