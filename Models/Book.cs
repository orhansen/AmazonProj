using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

//Main model that dictates how the database will be organized and what values are required.
namespace AmazonProj.Models
{
    public class Book
    {
        [Key]
        [Required]
        public int BookID { get; set; } //Key that is auto-generated and the PK for the database
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        [RegularExpression("[0-9]{3}-[0-9]{10}")] //Ensures the ISBN is inputted properly for future validation
        public string ISBN { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public int Pages { get; set; }
        [Required]
        public double Price { get; set; }

    }
}
