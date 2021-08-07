using System;
using System.ComponentModel.DataAnnotations;

namespace colourapiaugtwentyone.Models
{
    public class Colour
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Rgb { get; set; }
        public string Hex { get; set; }
    }
}
