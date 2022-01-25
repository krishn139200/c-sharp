using System;
	public class animal
	{
		public virtual void eat()
		{
			Console.WriteLine("Eating...");
		}
	}
	public class dog:animal
	{	
		public override void eat()
		{
			base.eat();
			Console.WriteLine("Eating Bread....");
		}
		public static void Main (string[] args)
		{
			dog d1 = new dog();
			d1.eat();
		}
	}
