using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookTest.Models
{
    public class Book
    {
        /// <summary>
        /// ISBNNumber
        /// </summary>
        [Key]
        public string ISBNNumber { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// CategoryId
        /// </summary>
        [ForeignKey("CategoryId")]
        public string CategoryId { get; set; }

        /// <summary>
        /// Categories
        /// </summary>
        public Category Categories { get; set; }

        /// <summary>
        /// Author
        /// </summary>
        public string Author { get; set; }
    }
}
