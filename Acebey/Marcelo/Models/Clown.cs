using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Marcelo.Models
{
    public enum TypeTricks
    {
        Malabarismo,
        Magia,
        MuerteFalsa,
    }
    public class Clown
    {
        [Key]
        public int ClownID { get; set; }
        [Required(ErrorMessage ="Nombre Completo")]
        [MinLength(2)]
        [MaxLength(24)]
        public String NickName { get; set; }
        [Required]
        public TypeTricks Tricks { get; set; }
        [EmailAddress(ErrorMessage ="")]
        [DataType(DataType.EmailAddress)]
        [StringLength(80)]
        public String Email { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
    }
}