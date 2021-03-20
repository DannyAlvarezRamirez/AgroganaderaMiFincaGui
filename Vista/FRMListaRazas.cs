using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroganaderaMiFincaGui
{
    /*
     * esta clase se encarga de desplegar los registros de razas
     */
    public partial class FRMListaRazas : Form
    {
        public FRMListaRazas()
        {
            InitializeComponent();
        }//fin constructor

        /*
         * este metodo se encarga de esconder el formulario actual
         */
        private void FRMListaRazas_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarFormulario);
        }//fin FRMListaRazas_Load

        /*
         * este metodo se encarga de esconder el formulario actual 
         */
        private void cerrarFormulario(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }//fin cerrarFormulario

    }//fin clase FRMListaRazas
}
