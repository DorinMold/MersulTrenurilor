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
        public int Id { get; set; }

        [Required]
        [Display(Name = "Data Bilet")]
        [StringLength(30)]
        public string DataBilet { get; set; }

        [Required]
        [Display(Name = "Distanta")]
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
        public string numePersoana { get; set; }

        [Required]
        public int Pret { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name="Prenume")]
        public string prenumePersoana { get; set; }

        [StringLength(30, MinimumLength = 10, ErrorMessage = "Minimum 10 caractere")]
        [RegularExpression(@"^07.+", ErrorMessage = "Numarul trebuie sa aiba formatul 07xxxxxxxx")]
        [Display(Name = "Numar Telefon")]
        [DisplayFormat(DataFormatString = "{0:XXXX.XXX.XXX}", ApplyFormatInEditMode = true)]
        public string numarTelefon { get; set; }

        [StringLength(30)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
