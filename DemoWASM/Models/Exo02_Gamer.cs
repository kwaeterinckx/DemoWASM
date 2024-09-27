using DemoWASM.Pages;
using System.ComponentModel.DataAnnotations;

namespace DemoWASM.Models
{
    public class Exo02_Gamer
    {
        public static int Counter { get; set; } = 1;
        public int Id { get; set; }

        [Required]
        public string Pseudo { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public DateOnly? DateNaissance { get; set; }

        public Exo02_Gamer()
        {
            Id = Counter++;
        }
    }
}
