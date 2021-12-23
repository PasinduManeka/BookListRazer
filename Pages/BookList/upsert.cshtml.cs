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
    public class upsertModel : PageModel
    {
        //create a object of the applicationDBContext for databse connection
        private readonly ApplicationDBContext _db;

        //initialize the constructor. Use the dependency injection
        public upsertModel(ApplicationDBContext db)
        {
            _db = db;
        }

        //Model
        [BindProperty]
        public Book Book { get; set; }

        //sometimes id will be null(?) because due to create operation.
        public async Task<IActionResult> OnGet(int? id)
        {
            Book = new Book();
            //Check id null or not
            if (id == null)
            {
                //create
                return Page();
            }
            //Populate the book object based on the databse with paseed ID
            //update
            Book = await _db.Book.FirstOrDefaultAsync(u => u.ID == id);
            if (Book == null)
            {
                return NotFound();
            }
            return Page();
            //Console.WriteLine("ID:",id);
        }

        //post handler
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                //check id null or not
                if (Book.ID == 0)
                {
                    _db.Book.Add(Book);
                }
                else
                {
                    _db.Book.Update(Book);
                }

                //Save change on the DB
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
