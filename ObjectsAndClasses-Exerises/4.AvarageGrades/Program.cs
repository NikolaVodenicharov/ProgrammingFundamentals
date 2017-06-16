using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.AvarageGrades
{
    class Student
    {
        public string Name { get; set; }

        public List<double> Grades { get; set; }

        public double AverageGrade
        {
            get { return Grades.Average(); }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string nameStudent = input[0];

                List<double> grades = new List<double>();
                for (int j = 1; j < input.Length; j++)
                {
                    double gr = double.Parse(input[j]);
                    grades.Add(gr);
                }

                Student student = new Student();
                student.Name = nameStudent;
                student.Grades = grades;

                students.Add(student);
            }

            foreach (Student stu in students.Where(s => s.AverageGrade >= 5).OrderBy(s => s.Name).ThenByDescending(s => s.AverageGrade))
            {
                Console.WriteLine($"{stu.Name} -> {stu.AverageGrade:f2}");
            }
        }
    }
}
