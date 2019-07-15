using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Person_20190710
{
    class Program
    {
        static void Main(string[] args)
        {
            Person first = new Person(new DateTime(1980, 07, 16), 20660716888);
            first.FirstName = "Владимир";
            first.LastName = "Орлов";
            first.MiddleName = "Александрович";

            Console.WriteLine("ФИО полностью \t" + first.GetLFM() + "\n");
            Console.WriteLine("Фамилия и И.О. \t" + first.GetLastNameAndFM() + "\n\n");

            Console.WriteLine("Дата рождения \t" + first.Birthday.ToShortDateString());
            Console.WriteLine("ИНН \t\t" + first.Inn);
            Console.WriteLine("Возраст \t" + first.Age());

            Person second = new Person(new DateTime(1860, 01, 29), 20456885556);
            second.FirstName = "Антон";
            second.LastName = "Чехов";
            second.MiddleName = "Павлович";
            
            first.InfoPerson();
            second.InfoPerson();

            Worker fw = new Worker(new DateTime(1980, 07, 16), 20660716888, new DateTime(2019, 07, 15), "developer", 5000);

            fw.InfoWorker();

            Console.ReadKey();
        }
    }
}


//На основании класс Person Создайте класс работника который содержит данные:
//    - Дата приема на работу,
//    - Должность,
//    - Оклад,
//и методы для доступа к данным.

//class Worker : Person
//{

//}
