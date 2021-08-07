using System;
using System.ComponentModel.DataAnnotations;

namespace colourapiaugtwentyone.Dtos
{
    public class ColourDto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Rgb { get; set; }
        public string Hex { get; set; }
    }
}
