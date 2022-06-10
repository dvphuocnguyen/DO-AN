using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Person:IPerson
	{
		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public string address { get; set; }
		public Person(string name, string address)
		{
			this.name = name;
			this.address = address;
		}
		public void show()
		{
			Console.WriteLine($"Name: {name}");
		}

		void IPerson.show()
		{
			throw new NotImplementedException();
		}
	}
}
