using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csi23iloposaTerceraEvaluacion.Dtos
{
    /// <summary>
    /// Clase Dtos la cual contiene los datos de los Pedidos
    /// <authors>ilp-04/03/224</authors>
    /// </summary>
    internal class PedidosDto
    {
        /// <summary>
        /// Atributos
        /// <author>ilp-04032024</author>
        /// </summary>
        string nombreProducto = "aaaa";
        long idProducto;
        int cantidadProducto = 1111;
        DateTime fechaDeEntrega = new DateTime(9999 / 12 / 31);

       

        /// <summary>
        /// Constructores
        /// <author>ilp-04032024</author>
        /// </summary>
        public PedidosDto(string nombreProducto, long idProducto, int cantidadProducto, DateTime fechaDeEntrega)
        {
            this.nombreProducto = nombreProducto;
            this.idProducto = idProducto;
            this.cantidadProducto = cantidadProducto;
            this.fechaDeEntrega = fechaDeEntrega;
        }
        public PedidosDto()
        {
        }
        /// <summary>
        /// Getters y Setters
        /// <author>ilp-04032024</author>
        /// </summary>
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }
        public DateTime FechaDeEntrega { get => fechaDeEntrega; set => fechaDeEntrega = value; }
        public long IdProducto { get => idProducto; set => idProducto = value; }

        override
            /// <summary>
            /// Metodo el cuall muestra por pantalla un listado de datos
            /// <author>ilp-04032024</author>
            /// </summary>
            public string ToString()
        {
            string datos = $"Producto: {this.nombreProducto}" +
                $"\nCantidad: {this.cantidadProducto}" +
                $"\nFecha entrega: {this.fechaDeEntrega}\n";
            return datos;
        }
       
    }
}
