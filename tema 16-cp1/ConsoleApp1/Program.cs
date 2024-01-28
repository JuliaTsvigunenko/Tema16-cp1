using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Задание 1.Вывести сообщение с информацией о текущей системной дате, применив несколько форматов.

            //Текущая дата:

            DateTime dt = DateTime.Now;

            Console.WriteLine(dt.ToString("dd.MM.yyyy")); //26.01.2024
            Console.WriteLine(dt.ToShortDateString()); //26.01.2024
            Console.WriteLine($"{dt:d}"); //26.01.2024
            Console.WriteLine($"{dt.ToString("d")}"); //26.01.2024

            Console.WriteLine(dt.ToString("dd MMM yyyy")); // 26 янв 2024

            Console.WriteLine(dt.ToLongDateString()); //26 января 2024 г.
            Console.WriteLine($"{dt.ToString("D")}"); //26 января 2024 г.
            Console.WriteLine(dt.ToString("dd MMMM yyy")); //26 января 2024 

            Console.WriteLine(dt.ToString("ddd, dd MMM yyyy")); //Пт, 26 янв 2024

            Console.WriteLine(dt.ToString("dddd, dd MMMM yyyy")); //пятница, 26 января 2022


            //Текущее время:

            Console.WriteLine(dt.ToLongTimeString()); //20:40:15
            Console.WriteLine(dt.ToShortTimeString()); //20:40


            //Текущая дата и время:

            Console.WriteLine($"{dt.ToShortDateString()} {dt.ToLongTimeString()}"); //28.01.2024 20:52:44
            Console.WriteLine($"{dt.ToString("D")} {dt.ToShortTimeString()}"); //28 января 2024 г. 20:57
            Console.WriteLine($"{dt.ToLongDateString()} {dt.ToLongTimeString()}"); //28 января 2024 г. 21:00:28

            Console.WriteLine(dt.ToString("R")); //Sun, 28 Jan 2024 21:01:37 GMT
            Console.WriteLine(dt.ToString("ddd, dd MMM yyyy HH:mm:ss 'GMT'")); //Вс, 28 янв 2024 21:03:19 GMT

            Console.WriteLine(dt.ToString("s")); //2024-01-28T21:04:18
            Console.WriteLine(dt.ToString("yyyy-MM-ddTHH:mm:ss")); //2024-01-28T21:05:26



            //Задание 2.Запросить с клавиатуры возраст человека и вывести на экран следующее сообщение: Ты родился в....году


            //Console.Write("Введите возраст человека:");
            //{
            //    int age = Convert.ToInt32(Console.ReadLine());
            //    int year = DateTime.Now.Year - DateTime.Now.Month - age;
            //    Console.WriteLine($"Ты родился в {year} году");
            //}



            //Задание 3.Определить возраст человека

            //Console.Write("Ваш год рождения: ");
            //{
            //    int year = Convert.ToInt32(Console.ReadLine());
            //    int age = DateTime.Now.Year - DateTime.Now.Month - year;
            //    Console.WriteLine($"Ваш возраст: {age}");
            //}


            Console.ReadKey();



            //DateTime birthday = new DateTime(2006, 05, 19);
            //DateTime now = new DateTime(2024, 01, 28);


        }
    }
}
