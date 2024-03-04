using csi23iloposaTerceraEvaluacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csi23iloposaTerceraEvaluacion.Servicios
{
    /// <summary>
    /// Interfaz la cual contiene los metodos del funcionamiento de la app
    /// <author>ilp-04032024</author>
    /// </summary>
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Metodo el cual genera un id automatico mediante la lista de ventas
        /// <author>ilp-04032024</author>
        /// </summary>
        /// <param name="listaVentas"></param>
        /// <returns></returns>
        public long idAutogenerado(List<VentasDto> listaVentas);
        /// <summary>
        /// Metodo el cual se encarga de aniadir una venta una venta nueva a la lista de ventas
        /// <author>ilp-04032024</author>
        /// </summary>
        /// <param name="listaVentas"></param>
        public double aniadirVenta(List<VentasDto> listaVentas);
        /// <summary>
        /// Metodo el caul se encarga de calcular el total de las ventas 
        /// <author>ilp-04032024</author>
        /// </summary>
        /// <param name="listaVentas"></param>
        public void calculoTotalDeVentas(List<VentasDto> listaVentas);

        /// <summary>
        /// Metodo el cual se encarga de mostrar todas las ventas del di
        /// <author>ilp-04032024</author>
        /// </summary>
        /// <param name="listaVentas"></param>
        public void mostrarVentasDelDia(List<VentasDto> listaVentas);
        /// <summary>
        /// Metodo el cual se pied unios datos de producto para realizar un pedido 
        /// <author>ilp-04032024</author>
        /// </summary>
        /// <param name="listaPedidos"></param>
        public void crearPedidoParaProveedores(List<PedidosDto> listaPedidos);

    }
}
