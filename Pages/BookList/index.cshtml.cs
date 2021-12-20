using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookListRazor.Pages.BookList
{
    public class indexModel : PageModel
    {
        //create a object of the applicationDBContext for databse connection
        private readonly ApplicationDBContext _db;

        //initialize the constructor. Use the dependency injection
        public indexModel(ApplicationDBContext db)
        {
            _db = db;
        }

        //return the books as a list
        public IEnumerable<Book> Books { get; set; }

        public async Task OnGet()
        {
            //set the all the books from database
            Books = await _db.Book.ToListAsync();
        }
    }
}
