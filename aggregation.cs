using System;
	public class Address
	{
		public string addressline,city,state;
		public Address (string addressline, string city, string state)
		{
			this.addressline = addressline;
			this.city = city;
			this.state = state;
		}
	}
	public class Employee 
	{
		public int id;
		public string name;
		public Address address;
		public Employee (int id, string name, Address address)
		{
			this.id = id;
			this.name = name;
			this.address = address;
		}
		public void display()
		{
			Console.WriteLine(id + " " + name + " " + address.addressline + " " + address.city + " " + address.state);
		}
		public static void Main(string[] args)
		{
			Address a1 = new Address("G-34","noida","up");
			Employee e1= new Employee(01,"sonoo",a1);
			e1.display();
		}
	}
