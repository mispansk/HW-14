using System;
using System.Collections.Generic;
using System.Text;

namespace HW_14
{
    /// <summary>
    /// модель класса Контакт (имя, фамилия, ном телефона, е-мейл)
    /// </summary>
    internal class Contact
    {
        public Contact(string name, string lastName, long phoneNumber, String email) // метод-конструктор
        {
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public String Name { get; }
        public String LastName { get; }
        public long PhoneNumber { get; }
        public String Email { get; }
    }
}
