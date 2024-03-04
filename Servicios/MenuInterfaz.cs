using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace csi23iloposaTerceraEvaluacion.Servicios
{
    /// <summary>
    /// Interfaz la cual contiene las cabeceras de los metodos encagardos de los menus
    /// <authors>ilp-04/03/224</authors>
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo el cual mostrara el menu principal
        /// <author>ilp-04032024</author>
        /// </summary>
        /// <returns></returns>
        public int menuYSellecion();


        /// <summary>
        /// Metodo el cual mostrara el menu Empleado
        /// <author>ilp-04032024</author>
        /// </summary>
        /// <returns></returns>
        public int menuYSellecionEmpleado();
        /// <summary>
        /// Metodo el cual mostrara el menu Gerencia
        /// <author>ilp-04032024</author>
        /// </summary>
        /// <returns></returns>
        public int menuYSellecionGerencia();
    }
}
