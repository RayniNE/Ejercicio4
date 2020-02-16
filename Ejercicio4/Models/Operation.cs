using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio4.Models
{
    public class Operation
    {
        [Display (Name = "Primer numero")]
        public double PrimerNumero { get; set; }

        [Display(Name = "Segundo numero")]
        public double SegundoNumero { get; set; }

        [Display(Name = "Resultado")]
        public double Resultado { get; set; }

        [Display(Name = "Operacion")]
        public OperationType OperationType { get; set; }
    }
}
