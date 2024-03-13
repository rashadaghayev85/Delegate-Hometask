using Delegate_HomeWorks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_HomeWorks.Services.Interfaces
{
    internal interface IBookService
    {
        List<Book> GetBookByAuthor(Predicate<Book> func);
    }
}
