using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Pages.BookList
{
    public class CreateModel : PageModel
    {
        //create a object of the applicationDBContext for databse connection
        private readonly ApplicationDBContext _db;

        //initialize the constructor. Use the dependency injection
        public CreateModel(ApplicationDBContext db)
        {
            _db = db;
        }

        //Model
        [BindProperty]
        public Book Book { get; set; }

        public void OnGet()
        {
        }

        //Post handler
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                //add book to the database
                await _db.Book.AddAsync(Book);
                //save the changes in database
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }

    }
}
