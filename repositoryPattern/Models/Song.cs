using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToEFCore.Models
{
    [Table("Tragoudia")]
    public class Song
    {
        [Key]
        public int song_Id { get; set; }
        public string Title { get; set; }

        [ForeignKey("Id")]
        public Artist artist { get; set; }
        public int Year { get; set; }

        public Song(string title, Artist artist, int year)
        {
            Title = title;
            this.artist = artist;
            Year = year;
        }
        public Song()
        {
            
        }
    }
}
