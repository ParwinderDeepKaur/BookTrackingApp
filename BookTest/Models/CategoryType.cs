using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookTest.Models
{
    public class CategoryType
    {
        /// <summary>
        /// Type
        /// </summary>
        [Key]
        public string Type { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

    }
}
