using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using Entidades;

namespace Patentes
{
    #region Delegados
    public delegate void MostrarPatente(object patente);
    public delegate void FinExposicionPatente(VistaPatente vp);
    #endregion

    public partial class VistaPatente : UserControl
    {
        
        

        public event FinExposicionPatente finExposicion;

        #region Metodos
        public VistaPatente()
        {
            InitializeComponent();

            picPatente.Image = fondosPatente.Images[(int)Patente.Tipo.Mercosur];
        }

        public void MostrarPatente(object patente)
        {
            if (lblPatenteNro.InvokeRequired)
            {
                try
                {
                    Random r = new Random();

                    // Llamar al hilo principal
                    //lblPatenteNro.BeginInvoke((MethodInvoker)delegate ()
                    //{
                    //    picPatente.Image = fondosPatente.Images[(int)((Patente)patente).TipoCodigo];
                    //    lblPatenteNro.Text = patente.ToString();
                    //});
                    lblPatenteNro.Invoke(new MostrarPatente(MostrarPatente), patente);

                    Thread.Sleep(r.Next(2000, 5000));

                    // Agregar evento de que finalizó la exposición de la patente
                    finExposicion(this);
                }
                catch (Exception) { }
            }
            else
            {
                picPatente.Image = fondosPatente.Images[(int)((Patente)patente).TipoCodigo];
                lblPatenteNro.Text = patente.ToString();
            }
        }
        #endregion
    }

}
