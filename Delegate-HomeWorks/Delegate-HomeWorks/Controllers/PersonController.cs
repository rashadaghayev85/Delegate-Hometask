using Delegate_HomeWorks.Models;
using Delegate_HomeWorks.Services;
using Delegate_HomeWorks.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_HomeWorks.Controllers
{
    internal class PersonController
    {
        private readonly IPersonService _personService;
        public PersonController()
        {
            _personService = new PersonService();
        }
        public void SearchForName()
        {
            var response = _personService.SearchForName(m => m.Name.Contains("E"));
            foreach (var item in response)
            {
                Console.WriteLine(item.Name + "-" + item.Surname);
            }


        }
        public void GetPersonBySalary()
        {
            var result = _personService.GetPersonBySalary(m=>m.Salary>1000);
            foreach (var person in result)
            {
                Console.WriteLine(person.Name+"-"+person.Surname+"-"+person.Address + "-" +person.Salary);
            }
        }
    }
}
