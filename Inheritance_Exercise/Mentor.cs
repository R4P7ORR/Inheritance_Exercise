using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise
{
	internal class Mentor : Person
	{
		private string level;
		public Mentor(string name, int age, string gender, string level) : base(name, age, gender)
		{
			this.name = name;
			this.age = age;
			this.gender = gender;
			this.level = level;
		}
		public Mentor() : base("Jane Doe", 30, "female")
		{
			this.level = "intermediate";
		}

		public override void getGoal()
		{
            Console.WriteLine("Educate brilliant junior software developers.");
		}
		public override void introduce()
		{
            Console.WriteLine($"Hi, I'm {this.name}, a {this.age} years old {this.gender} {this.level} mentor.");
        }
	}
}
