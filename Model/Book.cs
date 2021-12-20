using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class Book
    {
        [Key]
        public int ID { get; set; }

        public String Name { get; set; }
        public String Author { get; set; }
    }
}
