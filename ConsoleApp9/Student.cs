using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public enum Gender {male,female }
    public enum EducationForm { Direct,Found}

    public class Student
    {
        public string name { get; set; }
        public int group { get; set; }
        public int Gpa { get; set; }
        public Gender Gender { get; set; }
        public EducationForm EducationForm { get; set; }
        public int FamilySalary { get; set; }

        public Student(string Name,int group,int gpa,Gender gender,EducationForm educationForm,  int familySalary)
        {
            name = Name;
            Gpa = gpa;
            Gender = gender;
            EducationForm = educationForm;
            FamilySalary = familySalary;
        }
    }
}
