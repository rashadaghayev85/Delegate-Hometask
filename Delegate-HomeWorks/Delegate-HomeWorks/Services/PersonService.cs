using Delegate_HomeWorks.Data;
using Delegate_HomeWorks.Models;
using Delegate_HomeWorks.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_HomeWorks.Services
{
    internal class PersonService : IPersonService
    {
        public List<Person> GetPersonBySalary(Predicate<Person> func)
        {
            var persons = new List<Person>();
            foreach (var item in AppDbContext.person)
            {
                if (func(item))
                {
                    persons.Add(item);
                }
            }

            return persons;
            //var persons=AppDbContext.person.Where(m=>m.Salary>1500).ToList();
            //return persons;
        }

        public List<Person> SearchForName(Predicate<Person> func)
        {
            List<Person> persons = new();
            foreach (var item in AppDbContext.person)
            {
                if (func(item))
                {
                    persons.Add(item);
                }
            }

            return persons;
        }
    }
}
