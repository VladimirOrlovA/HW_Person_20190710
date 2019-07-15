using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Person_20190710
{
    internal class Worker : Person
    {
        public DateTime employmentDate { get; set; }
        public string position { get; set; }
        public int solary { get; set; }


        public Worker(DateTime birthday, long inn, DateTime employmentDate, string position, int solary) : base(birthday, inn)
        {
            this.employmentDate = employmentDate;
            this.position = position;
            this.solary = solary;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void InfoWorker()
        {
            Console.WriteLine("\n----------------- Информация о человеке -----------------\n\n");
            Console.WriteLine("ФИО полностью ----- " + GetLFM());
            Console.WriteLine("Дата рождения ----- " + Birthday);
            Console.WriteLine("Возраст ----------- " + Age());
            Console.WriteLine("ИНН --------------- " + Inn);
            Console.WriteLine("\n---------------------------------------------------------\n\n");
        }
    }
}
