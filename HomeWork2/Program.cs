using System;
using System.IO;
using Class;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 3.1. Создать enum");
            banklist name = banklist.текущий;
            name++;//Сберегательный
            Console.WriteLine($"{name}\n");
            Console.ReadKey();

            Console.WriteLine("Задание 3.2. Создать структуру Банк_List");
            Bank list  = new();
            list.number = 314159265358979;
            list.type = banklist.сберегательный;
            list.balance = 34;
            list.Print();
            Console.ReadKey();

            Console.WriteLine("Задание 3.3. Заполнить структуру и распечатать");
            Worker Bob = new Worker("Bob", vyz.КФУ);
            Bob.Print();
        }
    }
}