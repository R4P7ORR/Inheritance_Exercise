using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise
{
	internal class Person
	{
		protected string name;
		protected int age;
		protected string gender;

		public Person()
		{
			this.name = "Jane Doe";
			this.age = 30;
			this.gender = "female";
		}
		public Person(string name, int age, string gender)
		{
			this.name = name;
			this.age = age;
			this.gender = gender;
		}

		public virtual void getGoal()
		{
            Console.WriteLine("My goal is: Live for the moment!");
        }
		public virtual void introduce()
		{
            Console.WriteLine($"Hi, I'm {this.name}, a {this.age} years old {this.gender}.");
        }
	}
}
