using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MersTrenuri.Models
{
    public class Comanda
    {
        [Key]
        [Display(Name = "No.")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Date")]
        [StringLength(30)]
        public string DataBilet { get; set; }

        [Required]
        [Display(Name = "Km")]
        public int Distanta { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Departure")]
        public string statiePlecare { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name="Destination")]
        public string statieSosire { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name="Name")]
        [RegularExpression(@"[a-zA-Z]+", ErrorMessage = "You cannot insert special characters")]
        public string numePersoana { get; set; }

        [Required]
        public int Pret { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name="First Name")]
        [RegularExpression(@"[a-zA-Z]+", ErrorMessage = "You cannot insert special characters")]
        public string prenumePersoana { get; set; }

        [StringLength(30, MinimumLength = 10, ErrorMessage = "Minimum 10 characters")]
        [RegularExpression(@"^07[0-9]+$", ErrorMessage = "Your Phone Number has to be of type 07xxxxxxxx")]
        [Display(Name = "Telephone")]
        [DisplayFormat(DataFormatString = "{0:XXXX.XXX.XXX}", ApplyFormatInEditMode = true)]
        [DataType(DataType.PhoneNumber)]
        public string numarTelefon { get; set; }

        [StringLength(30)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
