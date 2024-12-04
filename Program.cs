// ***************************************************************
// Practica 07
// NAYELI MICAELA TELLO FLOREZ
// Fecha de realización: 27/11/2024
// Fecha de entrega: 04/12/2024
// ***************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmValidador());
        }
    }
}
