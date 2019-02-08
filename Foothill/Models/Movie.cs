using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Foothill.Models
{
    public class Cinema
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Month { get; set; }
        public string Day { get; set; }
        public string Year { get; set; }
        public short InStock { get; set; }
        
        public DateTime CreatedDt { get; set; }
        public Genre Genre { get; set; }
        public short GenreId { get; set; }

    }


    public class Genre
    {
        public short Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
    }
}