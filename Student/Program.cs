using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Student
{
    class Student
    {
        string f_name;
        string l_name;
        int age;
        double aver;
        double scholarship;
        static string group;
        static Student()
        {
            group = "PV-221";
        }
        public Student(string f_name, string l_name, int age, double aver, double scholarship)
        {
            this.f_name = f_name;
            this.l_name = l_name;
            this.age = age;
            this.aver = aver;
            this.scholarship = scholarship;
        }
        public double Scholarship(ref double scholarship)
        {
            return scholarship *= 12;
        }
        public double Aver_ball(ref double aver)
        {
            aver /= 12;
            return (aver - aver % 0.01);
        }
        public void Show()
        {
            Write($"{l_name} {f_name} {age} {"average score per month - "} {Aver_ball(ref aver)} ");
            WriteLine($"{"scholarship per year - "} {Scholarship(ref scholarship)} {"RUB"} {"group"} {group} ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Ivan", "Petrov", 23, 112.35, 5000);
            Student s2 = new Student("Petr", "Ivanov", 24, 100.54, 4500.25);
            Student s3 = new Student("Kris", "Evans ", 22, 103, 3700.58);
            Student s4 = new Student("Poll", "Smitt ", 18, 95.65, 4500);
            Student s5 = new Student("Ivan", "Lomov ", 19, 100.21, 5150.25);
            Student[] ar_st = { s1, s2, s3, s4, s5 };
            for (int i = 0; i < ar_st.Length; i++)
            {
                ar_st[i].Show();
            }
        }
    }
}
