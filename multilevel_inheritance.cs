using System;
	public class animal
	{
		public void eat()
		{
			Console.WriteLine ("eating...");
		}
	}
	public class dog:animal
	{
		public void bark()
		{
			Console.WriteLine("barking...");
		}
	}
	public class babydog:dog
	{
		public void weeping()
		{
			Console.WriteLine("Weeping...");
		}
	}
	public static class program
	{
		public static void Main(string[] args)
		{
			babydog d1 = new babydog();
			d1.eat();
			d1.bark();
			d1.weeping();
		}
	}
