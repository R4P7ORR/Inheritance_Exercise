using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise
{
	internal class Sponsor : Person
	{
		private string company;
		private int hiredStudents;
		public Sponsor(string name, int age, string gender, string company) : base(name, age, gender)
		{
			this.name = name;
			this.age = age;
			this.gender = gender;
			this.company = company;
			this.hiredStudents = 0;
		}
		public Sponsor() : base("Jane Doe", 30, "female")
		{
			this.company = "Google";
			this.hiredStudents = 0;
		}

		public override void getGoal()
		{
            Console.WriteLine("Hire brilliant junior software developers.");
        }
		public override void introduce()
		{
            Console.WriteLine($"Hi, I'm {this.name}, a {this.age} years old {this.gender} who represents " +
				$"{this.company} and hired {this.hiredStudents} students so far.");
        }
		public void hire()
		{
			this.hiredStudents ++;
		}
	}
}
