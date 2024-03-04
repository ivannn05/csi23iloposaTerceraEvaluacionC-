using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csi23iloposaTerceraEvaluacion.Servicios
{
    /// <summary>
    /// Implementacion la cual contiene la logica de los metodos de los menus
    /// <authors>ilp-04/03/224</authors>
    /// </summary>
    internal class MenuImplementacion: MenuInterfaz
    {
        public int menuYSellecion()
        {
            int opc;
            Console.WriteLine("Elija una opcion");
            Console.WriteLine("0.Cerrar Menu");
            Console.WriteLine("1.Menu Empleado");
            Console.WriteLine("2.Menu Gerencia");
            Console.WriteLine("----------------------------------------------------");
            opc = Convert.ToInt32(Console.ReadLine());


            return opc;
        }

        public int menuYSellecionEmpleado()
        {
            int opc;
            Console.WriteLine("Elija una opcion");
            Console.WriteLine("0.Cerrar Menu");
            Console.WriteLine("1.Añadir Venta");
            Console.WriteLine("2.Calculo Tota de ventas diario");
            Console.WriteLine("----------------------------------------------------");
            opc = Convert.ToInt32(Console.ReadLine());


            return opc;
        }

        public int menuYSellecionGerencia()
        {
            int opc;
            Console.WriteLine("Elija una opcion");
            Console.WriteLine("0.Cerrar Menu");
            Console.WriteLine("1.Mostrar ventas del dia");
            Console.WriteLine("2.Crear pedido para proveedores");
            Console.WriteLine("----------------------------------------------------");
            opc = Convert.ToInt32(Console.ReadLine());


            return opc;
        }
    }
}
