using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Turnos.Models
{
    public class Paciente
    {

        [Key]
        public int IdPaciente { get; set; }
        [Required (ErrorMessage ="Debe ingresar un Nombre.")]
         [Display (Name ="Nombre")]       
        public string Nombre {get;set;}
        [Required (ErrorMessage ="Debe ingresar un Apellido.")]
        [Display (Name ="Apellido")]
        public string Apellido {get;set;}
        [Required (ErrorMessage ="Debe ingresar una Dirección.")]
        [Display (Name ="Dirección")]
        public string Direccion {get;set;}
        [Required (ErrorMessage ="Debe ingresar un Teléfono.")]
        [Display (Name ="Teléfono")]
        public string Telefono {get;set;}
        [Required (ErrorMessage ="Debe ingresar un Email.")]
        [EmailAddress (ErrorMessage ="Dirección de correo incorrecto.")]
        public string Email {get;set;}
        public List<Turno> Turno {get;set;}
       
    }
}