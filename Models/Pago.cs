using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoInmobiliaria.Models
{
    public class Pago
    {
        [Key]
        public int IdPago { get; set; }
        public int NumPago { get; set; }
        public int IdContr { get; set; }
        public Contrato Contrato { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Importe { get; set; }

    }
}
