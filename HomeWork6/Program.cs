using System;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            //создадим объекты и заполним данные о нескольких студентах
            Student student1 = new Student("Иван", "Петров");
            student1.Marks = new int[] { 7,8,5,9,8,7};
            Student student2 = new Student("Петр", "Иванов");
            student2.Marks = new int[] { 4, 8, 7 };
            Student student3 = new Student("Андей", "Сергеев");
            student3.Marks = new int[] { 5, 6, 8, 7 };
            Student student4 = new Student("Максим", "Андреев");
            student4.Marks = new int[] { 8, 8, 6, 6, 8, 7 };
            Student student5 = new Student("Дарья", "Максимова");
            student5.Marks = new int[] { 6, 8, 7, 7 };

            StudentsGroup group1 = new StudentsGroup("СШ-2021");
            StudentsGroup group2 = new StudentsGroup("ФШ-2021");

            //распредилим студентов по группам
            group1.AddStudent(student1);
            group1.AddStudent(student2);

            group2.AddStudent(student3);
            group2.AddStudent(student4);
            group2.AddStudent(student5);

            //выводим оценки и средний балл
            group1.MarksOutput();
            Console.WriteLine();
            group1.AverageOutput();

            Console.WriteLine();

            group2.MarksOutput();
            Console.WriteLine();
            group2.AverageOutput();

            //переводим студента из группы ФШ-2021 в СШ-2021
            group2.Transfer(student5, group1);

            Console.WriteLine();
            Console.WriteLine("После перевода студента");
            Console.WriteLine();

            //выводим оценки и средний балл
            group1.MarksOutput();
            Console.WriteLine();
            group1.AverageOutput();

            Console.WriteLine();

            group2.MarksOutput();
            Console.WriteLine();
            group2.AverageOutput();


            Console.ReadLine();
        }
    }
}
