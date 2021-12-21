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
            //Async let you run mutiple tasks until it is waited
            Books = await _db.Book.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            //Find the exist data from the database
            var book = await _db.Book.FindAsync(id);
            if (book == null)
            {
                return RedirectToPage("Edit");
            }

            Console.WriteLine(book);

            //remove the book
            _db.Book.Remove(book);

            //Save the changes on the database
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
