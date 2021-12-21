using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Pages.BookList
{
    public class RemoveModel : PageModel
    {
        //create a object of the applicationDBContext for databse connection
        private readonly ApplicationDBContext _db;

        //initialize the constructor. Use the dependency injection
        public RemoveModel(ApplicationDBContext db)
        {
            _db = db;
        }

        //Model
        [BindProperty]
        public Book Book { get; set; }

        public async Task<IActionResult> OnGet(int id)
        {
            //Retrieve the book data from database
            var book =  await _db.Book.FindAsync(id);

            //check the that book available or not
            if (book == null)
            {
                NotFound();
            }

            //remove the book
            _db.Book.Remove(book);

            //save the changes in the databse
            await _db.SaveChangesAsync();
            return Redirect("Index");

        }
    }
}
