using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab3
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {

            //1)
            WriteLine("1)------------------------------------");
            StudentCollection studentCollection = new StudentCollection();
            studentCollection.AddDefaults();
            studentCollection.AddStudents(new Student[] { new Student(new Person("Volodymyr", "Mykytuk", new DateOnly(2001, 08, 15)), Education.SecondEducation, 407) { Exams = new List<Exam>() { new Exam("Math", 5, new DateOnly(2022, 06, 12)), new Exam("Python", 5, new DateOnly(2021, 12, 15)) }, Tests = new List<Test>() { new Test(), new Test("PHP", false), new Test("Access", true) } }, new Student(new Person("Mychailo", "Shelest", new DateOnly(2002, 02, 28)), Education.Master, 304) { Exams = new List<Exam>() { new Exam(), new Exam("Access", 3, new DateOnly(2021, 12, 12)) }, Tests = new List<Test>() { new Test() } } });
            WriteLine(studentCollection);
            WriteLine("----------------------------------------\n");


            //2)
            WriteLine("2)------------------------------------");
            WriteLine("--Sort by surname--\n");
            studentCollection.SortBySurname();
            WriteLine(studentCollection);
            WriteLine("--Sort by date--\n");
            studentCollection.SortByDate();
            WriteLine(studentCollection);
            WriteLine("--Sort by grade--\n");
            studentCollection.SortByGrade();
            WriteLine(studentCollection.ToShortString());
            WriteLine("----------------------------------------\n");

            //3)
            WriteLine("3)------------------------------------");
            WriteLine("--Max average grade--");
            WriteLine(studentCollection.MaxGrade);
            WriteLine("--Students with education Master--");
            foreach(Student stud in studentCollection.TypeEducation)
            {
                WriteLine(stud);
            }
            WriteLine("--Group students with mark--");
            foreach(Student stud in studentCollection.AverageMarkGroup(4.5))
            {
                WriteLine(stud);
            }
            WriteLine("----------------------------------------\n");

            //4)
            WriteLine("4)------------------------------------");
            TestCollections testCollection = new TestCollections(1000000);
            testCollection.TimeFinding(1000000);
            WriteLine("----------------------------------------\n");

        }
    }
}
