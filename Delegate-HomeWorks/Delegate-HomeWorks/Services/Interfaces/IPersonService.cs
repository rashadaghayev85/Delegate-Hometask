using Delegate_HomeWorks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_HomeWorks.Services.Interfaces
{
    internal interface IPersonService
    {
        List<Person> SearchForName(Predicate<Person> func);
        List<Person>GetPersonBySalary(Predicate<Person>func);
    }
}
