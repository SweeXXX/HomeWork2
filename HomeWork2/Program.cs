using System;
using System.IO;

enum banklist
{
    текущий,
    сберегательный
}
struct Bank
{
    public long number;
    public banklist type;
    public long balance;
    public Bank(int number, long balance, banklist type = banklist.сберегательный)
    {
        this.balance = balance;
        this.type = type;
        this.number = number;
    }
    public void Print()
    {
        Console.WriteLine($"Number: {number}\nType: {type}\nBalance: {balance}");
    }
}
namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 3.1");
            banklist name = banklist.текущий;
            name++;//Сберегательный
            Console.WriteLine($"{name}\n");
            Console.ReadKey();

            Console.WriteLine("Задание 3.2");
            Bank list  = new();
            list.number = 314159265358979;
            list.type = banklist.сберегательный;
            list.balance = 34;
            list.Print();
            Console.ReadKey();
        }
    }
}