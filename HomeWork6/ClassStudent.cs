using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork6
{
    public class Student

    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int[] Marks { get; set; }



        public Student(string firstName = "Безымянный", string lastName = "Безфамильный")
        {
            FirstName = firstName;
            LastName = lastName;
            Marks = new int[] { 0 };

        }

        public void MarksOutput()
        {
            Console.WriteLine($"Студент {FirstName} {LastName}");
            Console.Write($"Оценки: ");
            for (int i = 0; i < Marks.Length; i++)
            {
                Console.Write($"{Marks[i]} ");
            }
            Console.WriteLine();
        }
        public float AverageScore(bool output=false) //подсчет среднего балла с возможностью вывода
        {
            float sum = 0;
            for (int i = 0; i < Marks.Length; i++)
            {
                sum += Marks[i];
            }
            if (output)
            {
                Console.Write($"Студент {FirstName} {LastName} средний балл {(sum / Marks.Length): #.##}");
            }
            return sum / Marks.Length;
        }


    }

    public class StudentsGroup
    {
        public string GroupName { get; set; }
        public List<Student> Students { get; set; }

        public StudentsGroup(string name = "НоваяГруппа")
        {
            GroupName = name;
            Students = new List<Student>(1);
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="student">Студент, которого переводим</param>
        /// <param name="Group">Группа, в которую нужно перевести</param>
        /// <returns>true, если перевод успешный и false, если нет</returns>
        public bool Transfer(Student student, StudentsGroup Group)
        {

            if (Group != null)//если группа для перевода существует
            {
                bool result = Students.Remove(student);
                if (result)
                {
                    Group.AddStudent(student);
                }
            }

            return false;
        }

        public void MarksOutput()
        {
            Console.WriteLine($"Группа {GroupName} ");
            foreach (var stdnt in Students)
            {
                stdnt.MarksOutput();
            }
        }

        public void AverageOutput()
        {
            Console.WriteLine($"Группа {GroupName} ");
            foreach (var stdnt in Students)
            {
                stdnt.AverageScore(true);
                Console.WriteLine();
            }
        }
    }
}
