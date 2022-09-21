using System;
using System.Linq.Expressions;
using System.Net;
using System.Text;

struct Student//1 zadanie :D
{
    public string surname;
    public string name;
    public string dr;
    public int id;
    public double litrs;
    public alcogolizmCategory category;
    public Student(string name, string surname, string dr, int id, double litrs, alcogolizmCategory category)
    {
        this.name = name;
        this.surname = surname;
        this.dr = dr;
        this.id = id;
        this.litrs = litrs;
        this.category = category;
    }
}
public enum alcogolizmCategory
{
    alkogolic = 0,
    nealcash = 1,
    sometimes = 2,
    dontdrink = 3
}

namespace Home
{
    class Program
    {
        static void Main(string[] arg)
        {
            zad1();
            zad2();
            //zad3();
            //zad4();
            //zad5();
            //zad6();
            //zad7();
            static void zad1()
            {
                Student Nikita = new Student("Никита", "Полетаев", "12.12.2004", 228558, 5, alcogolizmCategory.alkogolic);
                Student Danisimus = new Student("Даня", "Морозов", "29.03.2005", 228558, 6, alcogolizmCategory.alkogolic);
                Student Nastya = new Student("Анастасия", "Тимофеева", "14.12.2003", 228558, 0.01, alcogolizmCategory.dontdrink);
                Student Farik = new Student("Фарит", "Аглиуллин", "20.09.2004", 228558, 1, alcogolizmCategory.sometimes);
                Student Macksim = new Student("Максим", "Коваль", "старше Земли", 1337, 2, alcogolizmCategory.sometimes);
                double alko = Nikita.litrs + Danisimus.litrs  + Farik.litrs + Nastya.litrs + Macksim.litrs;

                Console.WriteLine($"1 Задание.\nОбъём выпитого алкоголя: {alko}");
                Console.WriteLine($"{Nikita.name}: {Math.Round(Nikita.litrs/alko, 2)}%\n" +
                    $"{Danisimus.name}: {Math.Round(Danisimus.litrs/alko,2)}%\n" +
                    $"{Nastya.name}: {Math.Round(Nastya.litrs/alko, 2)}%\n" +
                    $"{Farik.name}: {Math.Round(Farik.litrs / alko, 2)}%\n" +
                    $"{Macksim.name}: {Math.Round(Macksim.litrs / alko, 2)}%\n");
            }

            static void zad2()
            {
                Console.WriteLine($"Тип - short.Максимальное - {short.MaxValue}.Минимальное - {short.MinValue}");
                Console.WriteLine($"Тип - ushort.Максимальное - {ushort.MaxValue}.Минимальное - {ushort.MinValue}");
                Console.WriteLine($"Тип - int.Максимальное - {int.MaxValue}.Минимальное - {int.MinValue}");
                Console.WriteLine($"Тип - uint.Максимальное - {uint.MaxValue}.Минимальное - {uint.MinValue}");
                Console.WriteLine($"Тип - long.Максимальное - {long.MaxValue}.Минимальное - {long.MinValue}");
                Console.WriteLine($"Тип - ulong.Максимальное - {ulong.MaxValue}.Минимальное - {ulong.MinValue}");
                Console.WriteLine($"Тип - float.Максимальное - {float.MaxValue}.Минимальное - {float.MinValue}");
                Console.WriteLine($"Тип - double.Максимальное - {double.MaxValue}.Минимальное - {double.MinValue}");
                Console.WriteLine($"Тип - decimal.Максимальное - {decimal.MaxValue}.Минимальное - {decimal.MinValue}");
                Console.WriteLine($"Тип - char.Максимальное - {char.MaxValue}.Минимальное - {char.MinValue}");
                Console.WriteLine($"Тип - byte.Максимальное - {byte.MaxValue}.Минимальное - {byte.MinValue}");
                Console.WriteLine($"Тип - sbyte.Максимальное - {sbyte.MaxValue}.Минимальное - {sbyte.MinValue}");
            }
            static void zad4()
            {
                Console.Write("4 Задание. Введите Имя и Фамилию через пробел ");
                string[]? fio = Console.ReadLine().Split();
                Console.WriteLine($"Приветствую, {fio[0][0]}.{fio[1][0]}, рад вас видеть \n");
            }
            static void zad5()
            {
                Console.Write("5 Задание.\nВведите стандартную цену: ");
                bool if1 = Int32.TryParse(Console.ReadLine(), out int normPrice);
                Console.Write("Введите процент скидки: ");
                bool if2 = Int32.TryParse(Console.ReadLine(), out int sale);
                Console.Write("Введите стоимость отпуска: ");
                bool if3 = Int32.TryParse(Console.ReadLine(), out int holidayPrice);
                Console.WriteLine($"Ответ: {Math.Ceiling((double)holidayPrice / (normPrice * (sale / 100.0)))}");
            }
            static void zad6()
            {
                Console.Write("6 Задание. Введите скорость таракана в км/ч: ");
                string str = Console.ReadLine().Replace(".", ",");
                bool Exep = double.TryParse(str, out double result);
                if (Exep)
                    Console.WriteLine($"Скорость такарана в см/с: {Math.Floor((result / 0.036))}");
                else
                    Console.WriteLine($"Надо было ввести число, чел ты...\n.\n.\n.\n");
            }
            static void zad7()
            {
                Console.Write("7 Задание.\nВведите строку: ");
                string? str = Console.ReadLine();

                string strNEW = "";
                foreach (var c in str)
                {
                    if (char.IsUpper(c))
                        strNEW += char.ToLower(c);
                    else
                        strNEW += char.ToUpper(c);

                }
                Console.WriteLine(strNEW);
            }
        }
    }
}
