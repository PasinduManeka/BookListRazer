using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Pages.BookList
{
    public class EditModel : PageModel
    {
        //create a object of the applicationDBContext for databse connection
        private readonly ApplicationDBContext _db;

        //initialize the constructor. Use the dependency injection
        public EditModel(ApplicationDBContext db)
        {
            _db = db;
        }

        //Model
        [BindProperty]
        public Book Book { get; set; }

        public async Task OnGet(int id)
        {
            //Populate the book object based on the databse with 
            //paseed ID
            Book = await _db.Book.FindAsync(id);
            //Console.WriteLine("ID:",id);
        }
    }
}
