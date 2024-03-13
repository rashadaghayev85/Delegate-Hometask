using Delegate_HomeWorks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_HomeWorks.Data
{
    internal class AppDbContext
    {
        public static List<Person> person;
        public static List<Book> book;
        static AppDbContext()
        {
            person = new List<Person>
            {
                new Person
                {
                    Id=1,
                    Name="Fexriyye",
                    Surname="Tagizade",
                    Address="28 may",
                    Salary=2100
                },
                new Person
                {
                    Id=2,
                    Name="Elmir",
                    Surname="Qafarzade",
                    Address="Sahil",
                    Salary=210
                },
                new Person
                {
                    Id=3,
                    Name="Sirac",
                    Surname="Memmedov",
                    Address="Masazir",
                    Salary=700
                },
                new Person
                {
                    Id=4,
                    Name="Rashad",
                    Surname="Aghayev",
                    Address="Neftciler",
                    Salary=7100
                },
                new Person
                {
                    Id=5,
                    Name="Behruz",
                    Surname="Eliyev",
                    Address="Kurdexani",
                    Salary=9900
                },
            };
            
            book = new List<Book>
            {
                new Book
                {
                    Id=1,
                    Name="Leyli ve Mecnun",
                    Author="Nizami"
                    
                },
                new Book
                {
                    Id=2,
                    Name="Xosrov ve Sirin",
                    Author="Nizami",
                   
                },
                new Book
                {
                    Id=3,
                    Name="Qeyri selis mentiq",
                    Author="Rashad Aghayev",
                    
                },
                new Book
                {
                    Id=4,
                    Name="Leyli ve Mecnun",                   
                    Author="Fuzuli"
                  
                },
                new Book
                {
                    Id=5,
                    Name="Sirrler xezinesi",
                    Author="Nizami"
                    
                },
            };

        }
    }
}
