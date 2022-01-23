using System;
	public class employee
	{
		public int id;
		public string name;
		public float salary;
		public void insert(int i, string n, float s)
		{
			id=i;
			name=n;
			salary=s;
		}
		public void display()
		{
			Console.WriteLine(id +" "+ name +" "+ salary);
		}
		public static void Main(string[] args)
		{
			employee e1 = new employee();
			employee e2 = new employee();
			e1.insert(01,"naman",80000f);
			e2.insert(02,"aman",90000f);
			e1.display();
			e2.display();
		}
		
	}
