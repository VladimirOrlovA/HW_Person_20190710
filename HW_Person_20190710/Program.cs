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

            Console.ReadKey();
        }
    }
}


//Создать класс Person и разработать программу для тестирования работы с данными человека.
//Поля: 
//•	Имя,
//•	Фамилия,
//•	Отчество,
//•	Год рождения,
//•	ИИН.
//Методы: 
//•	Возвращает строку с полным ФИО,
//•	Возвращает строку с фамилией и инициалами,
//•	Возвращает текущий возраст.
//Свойства:
//•	Имя,
//•	Фамилия,
//•	Отчество,
//•	Год рождения (для чтения),
//•	ИИН (для чтения).
//Конструктор:
//•	Год рождения,
//•	ИИН.
