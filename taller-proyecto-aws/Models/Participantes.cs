using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace taller_proyecto_aws.Models
{
    public class Participantes
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Display(Name ="Nombre:")]
        public string nombre { get; set; }
        [Display(Name = "Apellido:")]
        public string apellido { get; set; }
        [Display(Name = "Edad:")]
        public string edad { get; set; }
        [Display(Name = "Género:")]
        public string genero { get; set; }
        [Display(Name = "Ciudad:")]
        public string ciudad { get; set; }
        [Display(Name = "Tiempo (en min):")]
        public double tiempo { get; set; }
        [Display(Name = "Distancia (en km):")]
        public double distancia { get; set; }
        [Display(Name = "Ritmo promedio:")]
        public double ritmo { get; set; }
        [Display(Name = "Lugar:")]
        public string lugar { get; set; }
        [Display(Name = "Rol:")]
        public string rol { get; set; }
        [Display(Name = "Email:")]
        public string correo { get; set; }
    }
}
