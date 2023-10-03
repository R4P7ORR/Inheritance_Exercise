using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise
{
	internal class Student : Person
	{
		private string previousOrganization;
		private int skippedDays;

		public Student(string name, int age, string gender, string previousOrganization) : base(name, age, gender)
		{
			this.name = name;
			this.age = age;
			this.gender = gender;
			this.previousOrganization = previousOrganization;
			skippedDays = 0;
		}
		public Student() : base()
		{
			this.previousOrganization = "The School of Life";
			this.skippedDays = 0;
		}
		public override void getGoal()
		{
            Console.WriteLine("Be a junior software developer.");
        }
		public override void introduce()
		{
            Console.WriteLine($"Hi, I'm {base.name} a {base.age} years old {base.gender} from " +
				$"{this.previousOrganization} who skipped {this.skippedDays} days from the course already.");
        }
		public void skipdays(int numberOfDays)
		{
			this.skippedDays += numberOfDays;
		}
	}
}
