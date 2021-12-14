using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookTest.Models
{
    public class Category
    {
        /// <summary>
        /// NameToken
        /// </summary>
        [Key]
        [Required]
        [Display(Name = "Name Token")]
        public string NameToken { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [Required]
        public string Description { get; set; }

        /// <summary>
        /// TypeId
        /// </summary>
        [ForeignKey("TypeId")]
        [Display(Name = "Type")]
        public string TypeId { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        public CategoryType Type { get; set; }

       
    }
}
