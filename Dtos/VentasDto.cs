using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csi23iloposaTerceraEvaluacion.Dtos
{
    /// <summary>
    /// Clase dtos la cual contiene los datos de las ventas
    /// <authors>ilp-04/03/224</authors>
    /// </summary>
    internal class VentasDto
    {
        /// <summary>
        /// Atributos
        /// <author>ilp-04032024</author>
        /// </summary>
        long id;
        double importe = 1111;
        DateTime fechaCompra = DateTime.Today;

        /// <summary>
        /// Constructores
        /// <author>ilp-04032024</author>
        /// </summary>
        public VentasDto()
        {
        }

        public VentasDto(long id, double importe, DateTime fechaCompra)
        {
            this.id = id;
            this.importe = importe;
            this.fechaCompra = fechaCompra;   /* TimeSpan tiempo =fehc;*/
        }

        /// <summary>
        /// Getters y Setters
        /// <author>ilp-04032024</author>
        /// </summary>
        public long Id { get => id; set => id = value; }
        public double Importe { get => importe; set => importe = value; }
        public DateTime FechaCompra { get => fechaCompra; set => fechaCompra = value; }

        override
           /// <summary>
           /// Metodo el cuall muestra por pantalla un listado de datos
           /// <author>ilp-04032024</author>
           /// </summary>
           public string ToString()
        {
            string datos = $"Total de ventas: {this.importe}" +

                $"\nTiempo trascurrido: {this.fechaCompra}\n";
            return datos;
        }
    }
}
