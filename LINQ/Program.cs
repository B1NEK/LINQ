using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // создаём пустой список с типом данных Contact
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            // сортировка контактов по имени, а затем по фамилии
            phoneBook = phoneBook.OrderBy(contact => contact.Name).ThenBy(contact => contact.LastName).ToList();

            // вывод отсортированных контактов
            foreach (var contact in phoneBook)
            {
                Console.WriteLine($"{contact.Name} {contact.LastName}: {contact.PhoneNumber}, {contact.Email}");
            }
        }
    }

    public class Contact // модель класса
    {
        public Contact(string name, string lastName, long phoneNumber, String email) // метод-конструктор
        {
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public String Name { get; } // свойство для имени контакта
        public String LastName { get; } // свойство для фамилии контакта
        public long PhoneNumber { get; } // свойство для номера телефона контакта
        public String Email { get; } // свойство для адреса электронной почты контакта
    }
}

