using System;

namespace MyString
{
    public class MyString
    {
        public char[] Value { get; set; }

        public int Length
        {
            get

            {
                if (Value != null)
                {
                    return Value.Length;
                }
                return 0;
            }
        }


        public MyString(string str)  //конструктор с параметром string

        {
            if (str != null)
            {
                Value = str.ToCharArray();
            }
            else
            {
                Value = new char[0];
            }

        }

        public MyString(char[] charArray) //конструктор с параметром char array

        {
            if (charArray != null)
            {
                Value = charArray;
            }
            else
            {
                Value = new char[0];
            }
        }

        public static MyString operator +(MyString myString1, MyString myString2)  //перегружаемый оператор плюс
        {
            if (myString1 != null && myString2 != null)
            {
                char[] newString = new char[myString1.Length + myString2.Length];

                for (int i = 0; i < myString1.Length; i++)
                {
                    newString[i] = myString1.Value[i];
                }
                for (int i = 0; i < myString2.Length; i++)
                {
                    newString[i + myString1.Length] = myString2.Value[i];
                }
                return new MyString(newString);
            }
            else
                return null;
        }

        public int IndexOf(char symblol) //поиск индекса первого вхождения заданного элемента, -1 если элемент отсутствует
        {
            for (int i = 0; i < Length; i++)
            {
                if (Value[i] == symblol)
                {
                    return i;
                }
            }
            return -1;
        }

        public int LastIndexOf(char symblol) //поиск индекса последнего вхождения заданного элемента, -1 если элемент отсутствует
        {
            int result = -1;
            for (int i = 0; i < Length; i++)
            {
                if (Value[i] == symblol)
                {
                    result = i;
                }
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyString myString1 = new MyString("Пример1");//использование первого конструктора
            char[] myArray = new char[] { 'П', 'р', 'и', 'м', 'е','р','2' };
            MyString  myString2 =  new MyString(myArray);//использование второго конструктора
            MyString sumString = myString1 + myString2;
            Console.WriteLine(sumString.Value);
            Console.WriteLine($"Первое вхождение символа 'П': {sumString.IndexOf('П')}");
            Console.WriteLine($"Последнее вхождение символа 'П': {sumString.LastIndexOf('П')}");
            Console.ReadKey();

        }
    }
}



