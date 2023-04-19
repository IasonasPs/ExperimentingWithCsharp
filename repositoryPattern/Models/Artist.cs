using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToEFCore.Models
{   [Table("Composers")]
    public class Artist
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public Artist(string name, string country)
        {
            Name = name;
            Country = country;
        }
        public Artist()
        {
            
        }
    }
}
