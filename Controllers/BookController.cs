using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Controllers
{
    [Route("api/Book")]
    [ApiController]
    public class BookController : Controller
    {
        //API calls for retriev all the books in json format
        //and delete the books

        //create a object of the applicationDBContext for databse connection
        private readonly ApplicationDBContext _db;

        //initialize the constructor. Use the dependency injection
        public BookController(ApplicationDBContext db)
        {
            _db = db;
        }

        //Here we need to implement HTTP DELETE and HTTP GET

        //Get data
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new {data =await  _db.Book.ToListAsync()});
        }
    }
}
