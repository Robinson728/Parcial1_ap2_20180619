using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1_ap2_20180619.Models
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        
        [Required(ErrorMessage = "Por favor llenar campo.")]
        public string Descripcion { get; set; }

        [Range(0.1, 100000, ErrorMessage = "El valor debe ser mayor a cero.")]
        public int Existencia { get; set; }

        [Range(0.1, 10000000, ErrorMessage = "El valor debe ser mayor a cero.")]
        public double Costo { get; set; }

        public double ValorInventario { get; set; }
    }
}
