using csi23iloposaTerceraEvaluacion.Dtos;
using csi23iloposaTerceraEvaluacion.Servicios;

namespace csi23iloposaTerceraEvaluacion
{
    class Program
    {/// <summary>
     /// Metodo principal por el cual se lanzara la aplicacion
     /// <author>ilp-04032024</author>
     /// </summary>
     /// <param name="args"></param>
        public static void Main(string[] args)
        {
            int opcion;
            bool cerrarMenu=false;
            bool cerrarMenuGerencia = true;
            List<VentasDto> ventas = new List<VentasDto>();
            List<PedidosDto> pedidos = new List<PedidosDto>();
            MenuInterfaz mi= new MenuImplementacion();
            OperativaInterfaz op= new OperativaImplementacion();

            while(!cerrarMenu)
            {
                opcion = mi.menuYSellecion();

                switch (opcion) 
                {
                    case 0:
                        Console.WriteLine("Se cerrara el menu");
                        cerrarMenu = true;

                        break;
                    case 1:
                        Console.WriteLine("Accedio a menu Empleado");
                        int opcionEmpleado= mi.menuYSellecionEmpleado();
                        switch (opcionEmpleado)
                        {
                            case 1:
                                Console.WriteLine("Accedio a añadir venta");
                                
                                op.aniadirVenta(ventas);
                                break;
                            case 2:
                                Console.WriteLine("Accedio a calculo de ventas");
                               
                                op.calculoTotalDeVentas(ventas);
                                break;


                        }
                        break;
                    case 2:
                        Console.WriteLine("Accedio a menu Gerencia");
                        do
                        {
                           
                            int opcionGerencia = mi.menuYSellecionGerencia();
                            switch (opcionGerencia)
                            {
                                case 0:
                                    Console.WriteLine("Se cerrara el menu Gerencia");
                                    cerrarMenuGerencia = true;
                                    break;
                                case 1:
                                    Console.WriteLine("Accedio a Mostrar Ventas del dia");
                                    op.mostrarVentasDelDia(ventas);
                                    break;
                                case 2:
                                    Console.WriteLine("Accedio a Crear Pedido para proveedores");
                                    op.crearPedidoParaProveedores(pedidos);
                                    break;
                            }
                        } while (!cerrarMenuGerencia);
                            break;
                }


            }
        }
    }
}