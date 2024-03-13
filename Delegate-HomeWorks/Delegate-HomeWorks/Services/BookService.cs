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
    internal class BookService : IBookService
    {
        
        

        List<Book> IBookService.GetBookByAuthor(Predicate<Book> func)
        {
            var books = new List<Book>();
            foreach (var item in AppDbContext.book)
            {
                if (func(item))
                {
                    books.Add(item);
                }

            }
            return books;
        }
    }
}
