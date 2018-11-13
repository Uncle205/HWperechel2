using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Балжигитов Бекдос", 2, 4, Gender.male, EducationForm.Found, 200000));
            students.Add(new Student("Нариман Нарымбеков ", 1, 5, Gender.male, EducationForm.Direct, 100000 ));
            students.Add(new Student("Арений Культиков", 3, 3, Gender.male, EducationForm.Found, 5444000));

            int minSalary = 100000;

            var grant = students.Where(a => ((a.FamilySalary<= minSalary) || ( a.FamilySalary <= minSalary)) && a.EducationForm == EducationForm.Direct).OrderByDescending(a => a.Gpa);
            foreach (var grants in grant)
            {
                Console.WriteLine("ФИО: " + grants.name);
                Console.WriteLine("Пол: " + grants.Gender);
                Console.WriteLine("Группа: " + grants.group);
                Console.WriteLine("Средняя оценка: " + grants.Gpa);
                Console.WriteLine();
            }
        }
    }
}
