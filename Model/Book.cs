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

        //Name is required
        [Required]
        public String Name { get; set; }
        [Required]
        public String Author { get; set; }
        [Required]
        public String ISBN { get; set; }
    }
}
