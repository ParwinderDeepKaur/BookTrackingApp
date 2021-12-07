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
        public string NameToken { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// TypeId
        /// </summary>
        [ForeignKey("TypeId")]
        public string TypeId { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        public CategoryType Type { get; set; }

       
    }
}
