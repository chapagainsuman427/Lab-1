using System;

namespace Inheritance
{

    public class Student
    {
        string name; 
        int rollNo;

        public void addStudent(string Name, int RollNo)
        {
            name = Name;
            rollNo = RollNo;
        }

        public void personalDetail()
        {
            Console.WriteLine("Hello, this is {0} and my roll number is {1}", name, rollNo);
        }
    }

     public class MarkSheet: Student 
    {
        public int marksInCDC, marksInNCC, marksInSE;
        float percentage;


        public MarkSheet(int CDC, int NCC, int SE)
        {
            marksInCDC = CDC;
            marksInNCC = NCC;
            marksInSE = SE;

            percentage = (marksInCDC+marksInNCC+marksInSE)/3;
        }

        public void Result()
        {
            addStudent("Suman",15857);
            this.personalDetail();
            Console.WriteLine("I got {0} percentage.", percentage);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MarkSheet no1 = new MarkSheet(75,78,65);
            no1.Result();
        }
    }
}
