using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
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
}
