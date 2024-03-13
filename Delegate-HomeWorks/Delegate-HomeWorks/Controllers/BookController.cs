using Delegate_HomeWorks.Services;
using Delegate_HomeWorks.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_HomeWorks.Controllers
{
    internal class BookController
    {
        private readonly IBookService _bookService;
        public BookController()
        {
            _bookService=new BookService();
        }
        public void GetBookByAuthor()
        {
            Console.WriteLine("enter a author");
            var author=Console.ReadLine();
            var response = _bookService.GetBookByAuthor(m => m.Author.ToLower().Trim().Contains(author.ToLower().Trim()));
            foreach (var item in response)
            {
                Console.WriteLine(item.Name + "-" + item.Author);
            }
        }
    }
}
