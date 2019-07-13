﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Person_20190710
{
    class ClassPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime Birthday { get; }
        public long Inn { get; }

        public ClassPerson(DateTime birthday, long inn)
        {
            this.Birthday = birthday;
            this.Inn = inn;
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

        
        // Возвращает строку с полным ФИО
        public string GetLFM()
        {
            return (LastName + " " + FirstName + " " + MiddleName);
        }

        // Возвращает строку с фамилией и инициалами
        public string GetLastNameAndFM()
        {
            return (LastName + " " + FirstName.Substring(0,1) + "." + MiddleName.Substring(0,1) + ".");
        }

        //Возвращает текущий возраст
        public int Age()
        {
            return DateTime.Today.Year - Birthday.Year;
        }

    }

}
