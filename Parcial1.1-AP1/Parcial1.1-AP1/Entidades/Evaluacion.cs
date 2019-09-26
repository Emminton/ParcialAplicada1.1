using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1._1_AP1.Entidades
{
   public class Evaluacion
    {
        [Key]
        public int IDEvaluacion { get; set; }
        public string nombre { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Valor { get; set; }
        public decimal Obtenido { get; set; }
        public decimal Perdido { get; set; }

        public string Pronostico { get; set; }

        public Evaluacion(int iDEvaluacion, string nombre, DateTime fecha, decimal valor, decimal obtenido, decimal perdido, string pronostico)
        {
            IDEvaluacion = iDEvaluacion;
            this.nombre = nombre;
            Fecha = fecha;
            Valor = valor;
            Obtenido = obtenido;
            Perdido = perdido;
            Pronostico = pronostico;
        }

        public Evaluacion()
        {

        }
   }
}
