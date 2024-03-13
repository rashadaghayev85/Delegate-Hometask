using Delegate_HomeWorks;
using Delegate_HomeWorks.Controllers;

DelegatePractice delegatePractice = new DelegatePractice();
delegatePractice.Execute();
//delegatePractice.SumOfNumsByCondition(new List<int> { 1, 2, 3, 4, 5 }, m => m > 3);


PersonController personController = new PersonController();
//personController.SearchForName();
//personController.GetPersonBySalary();

BookController bookController = new BookController();
bookController.GetBookByAuthor();