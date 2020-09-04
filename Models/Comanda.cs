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
        [Display(Name = "Nr.")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Data Bilet")]
        [StringLength(30)]
        public string DataBilet { get; set; }

        [Required]
        [Display(Name = "Km")]
        public int Distanta { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Plecare")]
        public string statiePlecare { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name="Destinatie")]
        public string statieSosire { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name="Nume")]
        [RegularExpression(@"[a-zA-Z]+", ErrorMessage = "Nu poti insera caractere speciale")]
        public string numePersoana { get; set; }

        [Required]
        public int Pret { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name="Prenume")]
        [RegularExpression(@"[a-zA-Z]+", ErrorMessage = "Nu poti insera caractere speciale")]
        public string prenumePersoana { get; set; }

        [StringLength(30, MinimumLength = 10, ErrorMessage = "Minimum 10 caractere")]
        [RegularExpression(@"^07[0-9]+$", ErrorMessage = "Numarul trebuie sa aiba formatul 07xxxxxxxx")]
        [Display(Name = "Telefon")]
        [DisplayFormat(DataFormatString = "{0:XXXX.XXX.XXX}", ApplyFormatInEditMode = true)]
        [DataType(DataType.PhoneNumber)]
        public string numarTelefon { get; set; }

        [StringLength(30)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
