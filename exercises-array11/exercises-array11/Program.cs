using System;

namespace exercises_array11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*11) Написать программу, которая будет спрашивать имя и возраст двух человек, 
                после чего спросит, человек с каким именем старше ? (одно из ранее введенных).
                После ввода имени, программа должна вывести ответ, правильно или не правильно, и написать, кто старше, и на сколько.
                Предусмотреть ввод невалидных данных, и повторное отображение вопроса с повторным вводом при вводе невалидных данных.*/
                Console.WriteLine("Введите имя первого человека:");
                string name1; 
                uint countofInvalid;
                string symbolInvalid = "1234567890/} {)(|@%$&*!?,.`~=-#";
                do
                {
                    countofInvalid = 0;
                    name1 = Console.ReadLine();
                    foreach (char numb1 in name1)
                    {
                        foreach (char numb2 in symbolInvalid)
                            if (numb1 == numb2)
                            {
                                countofInvalid++;
                            }
                    }
                    if (countofInvalid > 0)
                    {
                        Console.WriteLine("Имя введенно не корректно,ведите имя повторно");
                    }
                }
                while (countofInvalid > 0);                
                Console.WriteLine("Введите возраст первого человека");
                uint years1;
                UInt32.TryParse(Console.ReadLine(), out years1);
                if (years1 < 1 || years1 > 99)
                {
                    while (years1 < 1 || years1 > 99)
                    {
                        Console.WriteLine("Ведено недопустимое значение, пожалуйста повторите ввод:");
                        UInt32.TryParse(Console.ReadLine(), out years1);
                    }
                }
                Console.WriteLine("Введите имя второго человека:");
                string name2;              
                do
                 {
                    countofInvalid = 0;
                    name2 = Console.ReadLine();
                    foreach (char numb1 in name2)
                   {
                      foreach (char numb2 in symbolInvalid)
                          if (numb1 == numb2)
                          {
                              countofInvalid++;
                          }
                   }
                  if (countofInvalid > 0)
                  {
                       Console.WriteLine("Имя введенно не корректно,ведите имя повторно");
                  }
                 }
                while (countofInvalid > 0);
                Console.WriteLine("Введите возраст второго человека");
                uint years2;
                UInt32.TryParse(Console.ReadLine(), out years2);
                if (years2 < 1 || years2 > 99)
                {
                    while (years2 < 1 || years2 > 99)
                    {
                        Console.WriteLine("Ведено недопустимое значение, пожалуйста повторите ввод:");
                        UInt32.TryParse(Console.ReadLine(), out years2);
                    }
                }
                uint difference;
                string nameverification;
                if (years1 > years2)
                {
                    Console.WriteLine("Введите имя человека, который по вашему мнению старший:");
                    nameverification = Console.ReadLine();
                    if (nameverification == name1)
                    {
                        difference = years1 - years2;
                        Console.WriteLine($"Правильно. Человек по имени {name1} старше на {difference} год.");
                    }
                    else if (nameverification != name1 && nameverification != name2)
                    {
                        Console.WriteLine("Ошибка! Такого имени нет в базе.");
                    }
                    else if (nameverification != name1)
                    {
                        difference = years1 - years2;
                        Console.WriteLine($"Неправильно. Человек по имени {name1} старше на {difference} год.");
                    }
                }
                else if (years2 > years1)
                {
                    Console.WriteLine("Введите имя человека, который по вашему мнению старший:");
                    nameverification = Console.ReadLine();
                    if (nameverification != name2 && nameverification != name1)
                    {
                        while (nameverification != name2 && nameverification != name1)
                        {
                            Console.WriteLine("Ошибка! Такого имени нет в базе. Попробуйте ввести еще раз:");
                            nameverification = Console.ReadLine();
                        }
                    }
                    if (nameverification == name2)
                    {
                        difference = years2 - years1;
                        Console.WriteLine($"Правильно. Человек по имени {name2} старше на {difference} год .");
                    }
                    else if (nameverification != name2 && nameverification != name1)
                    {
                        Console.WriteLine("Ошибка! Такого имени нет в базе.");
                    }
                    else if (nameverification != name2)
                    {
                        difference = years2 - years1;
                        Console.WriteLine($"Неправильно. Человек по имени {name2} старше на {difference} год.");
                    }
                }
                else if (years1 == years2)
                {
                    Console.WriteLine($"{name1} и {name2} ровесники!");
                }
                Console.ReadKey();      
        }
    }
}
