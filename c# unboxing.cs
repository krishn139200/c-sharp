// C# implementation of Boxing
using System;

class program {

	// Main Method
	static public void Main()
	{
		// int value data type
		int val = 8;

		// boxing
		object obj = val;
		//unboxing
		int val2 = (int)obj;

		Console.WriteLine("val = {0}", val);
		Console.WriteLine("obj = {0}", obj);
		Console.WriteLine("val2 ={0}", val2);
		
	}
}
