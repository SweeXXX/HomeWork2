using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public enum Banklist
    {
        текущий,
        сберегательный
    }
    public enum Vyz
    {
        КФУ,
        КАИ,
        КХТИ
    }
    public struct Worker
    {
        public string name;
        public Vyz Vyz;
        public Worker(string name, Vyz Vyz)
        {
            this.name = name;
            this.Vyz = Vyz;
        }
        public void Print(bool Enter=true)
        {
            
            Console.WriteLine(Enter? $"name: {this.name}\nVyz: {this.Vyz}\n": $"name: {this.name}\nVyz: {this.Vyz}");
        }
    }
    public struct Bank
    {
        public long number;
        public Banklist type;
        public long balance;
        public Bank(int number, long balance, Banklist type = Banklist.сберегательный)
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
}
