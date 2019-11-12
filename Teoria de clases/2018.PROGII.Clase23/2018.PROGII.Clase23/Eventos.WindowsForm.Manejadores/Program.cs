using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Eventos.WindowsForm.Manejadores
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

            frmManejadores frm = new frmManejadores();

            try
            {
                frm.StartPosition = FormStartPosition.CenterScreen;
                Application.Run(frm);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

        }
    }
}
