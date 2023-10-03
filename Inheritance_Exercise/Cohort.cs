using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise
{
	internal class Cohort
	{
		private string name;
		private List<Student> students;
		private List<Mentor> mentors;
		public Cohort(string name)
		{
			this.name = name;
			students = new List<Student>();
			mentors = new List<Mentor>();
		}
		public void addStudent(Student studentToAdd)
		{
			students.Add(studentToAdd);
		}
		public void addMentor(Mentor mentorToAdd)
		{
			mentors.Add(mentorToAdd);
		}
		public void info()
		{
            Console.WriteLine($"The {this.name} cohort has {students.Count} students, and {mentors.Count} mentors.");
        }
	}
}
