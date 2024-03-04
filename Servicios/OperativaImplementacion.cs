using csi23iloposaTerceraEvaluacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csi23iloposaTerceraEvaluacion.Servicios
{
    /// <summary>
    /// Implementacion la cual contiene la logica de los metodos de la app
    /// <author>ilp-04032024</author>
    /// </summary>
    internal class OperativaImplementacion : OperativaInterfaz
    {
        double cantidadDineroVentas;
        public double aniadirVenta(List<VentasDto> listaVentas)
        {
            VentasDto ventas = new VentasDto();
            Console.WriteLine("\tEscriba el importe de la venta");
            double importe = Convert.ToDouble(Console.ReadLine());
            ventas.Importe = importe;

            cantidadDineroVentas = importe = cantidadDineroVentas;

            ventas.Id = idAutogenerado(listaVentas);
            listaVentas.Add(ventas);
            return cantidadDineroVentas;
        }
        
        public void calculoTotalDeVentas(List<VentasDto> listaVentas)
        {
            VentasDto calculoVenta = new VentasDto();
            Console.WriteLine("\tEscriba la fecha de la venta en formato (dd-MM-yyyy)");
            string fecha=Console.ReadLine();
            DateTime fechausu =DateTime.Parse(fecha);

            foreach(VentasDto bucleVentas in listaVentas)
            { 
                if (fechausu == calculoVenta.FechaCompra)
                {
                 calculoVenta.ToString();
                }
            }

            int posicion = listaVentas.Count - 1;
            DateTime nuevaFecha = listaVentas[posicion].FechaCompra;
            TimeSpan tiempoTranscurrido = listaVentas[0].FechaCompra - nuevaFecha;
            int horas=tiempoTranscurrido.Hours;
            int minutos=tiempoTranscurrido.Minutes;
            int segundos=tiempoTranscurrido.Seconds;

            Console.WriteLine($"\nTotal de ventas:  { cantidadDineroVentas} euros" +
                $"\nTiempo transcurrido:{horas} horas {minutos} minutos {segundos} segundos ");
        }

        public void crearPedidoParaProveedores(List<PedidosDto> listaPedidos)
        {
            PedidosDto pedidos = new PedidosDto();
            pedidos.IdProducto = idAutogeneradoProductos(listaPedidos);
            Console.WriteLine("\tEscriba el nombre del producto");
            pedidos.NombreProducto = Console.ReadLine();
            Console.WriteLine("\tEscriba la cantidad del producto");
            pedidos.CantidadProducto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\tEscriba la fecha deseada de la entrega en formato (dd-MM-yyyy)");
            string fecha = Console.ReadLine();
            DateTime fechausu = DateTime.Parse(fecha);
            pedidos.FechaDeEntrega=fechausu;
            listaPedidos.Add(pedidos);

            Console.WriteLine(pedidos.ToString());
        }
        /// <summary>
        /// Metodo el cual genera una id autimatica para los productos
        /// <authors>ilp-04032024</authors>
        /// </summary>
        /// <param name="listaPedidos"></param>
        /// <returns></returns>

        //Se que esta mal crear otro metodo y no reeutilizar el metodo idAutogenerado publico ,
        //pero usan lista distintas y para que no se mezclaran 
        private long idAutogeneradoProductos(List<PedidosDto> listaPedidos)
        {
            long id;

            if (listaPedidos.Count == 0)
            {
                id = 1;
            }
            else
            {
                int posicion = listaPedidos.Count - 1;
                long nuevoId = listaPedidos[posicion].IdProducto + 1;
                id = nuevoId;
            }

            return id;

        }

        public long idAutogenerado(List<VentasDto> listaVentas)
        {
            long id;

            if(listaVentas.Count == 0)
            {
                id = 1;
            }
            else
            {
                int posicion = listaVentas.Count - 1;
                long nuevoId = listaVentas[posicion].Id + 1;
                id=nuevoId;
            }

            return id;

        }

        public void mostrarVentasDelDia(List<VentasDto> listaVentas)
        {
            string rutaArchivo = ("C:\\Users\\Trabajo\\Desktop\\");
            Console.WriteLine("\tEscriba la fecha de la venta en formato (dd-MM-yyyy)");
            string fecha = Console.ReadLine();
            DateTime fechausu = DateTime.Parse(fecha);
            string ruta = rutaArchivo+fecha + ".txt";
            string datosFichero = crearFichero();
            using (StreamWriter fichero = new StreamWriter(rutaArchivo))
            {
                foreach(VentasDto dto in listaVentas)
                {
                    fichero.Write(datosFichero);
                }

            }

        }


        /// <summary>
        /// Metodo el cual genera el fichero
        /// <author>ilp-04032024</author>
        /// </summary>
        /// <returns></returns>
        private string crearFichero()
        {
            VentasDto calculoVenta = new VentasDto();
            string contenido = 
                $"\n………." +
                $"\nVenta número:{calculoVenta.Id}" +
                $"\r\nEuros: {calculoVenta.Importe}" +
                $"\r\nInstante de compra:{calculoVenta.FechaCompra}" +
                $"\n……….\n";
            return contenido;
        }
    }
}
