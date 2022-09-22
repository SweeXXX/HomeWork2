using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public enum banklist
    {
        текущий,
        сберегательный
    }
    public enum vyz
    {
        КФУ,
        КАИ,
        КХТИ
    }
    public struct Worker
    {
        public string name;
        public vyz Vyz;
        public Worker(string name, vyz Vyz)
        {
            this.name = name;
            this.Vyz = Vyz;
        }
        public void Print()
        {
            Console.WriteLine($"name: {this.name}\nVyz: {this.Vyz}");
        }
    }
    public struct Bank
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
}
