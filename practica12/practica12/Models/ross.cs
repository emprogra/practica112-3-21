using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace practica12.Models
{
    public enum Departamentos
    {
        Santa_Cruz,
        Cochabamba,
        La_Paz,
        Oruro,
        Tarija,
    }
    public enum SexType
    {
        Femenino = 0,
        Masculino = 1,
    }

    public class ross
    {
        [Key]
        public int rossID { get; set; }

        [Required]
        [Display(Name = "Nombre Completo")]
        [StringLength(24, MinimumLength = 2, ErrorMessage = "Ingrese nombre entre 2 a 24 caracteres")]
        public string Friendofross { get; set; }

        [Required]
        public Departamentos place { get; set; }
        [EmailAddress(ErrorMessage = "Ingrese correo valido")]
        public string Email { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime Birthdate { get; set; }
        public SexType Sex { get; set; }


    }
}