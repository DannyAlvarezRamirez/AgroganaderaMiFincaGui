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
 * Este esta clase despliega la interfaz de usuario que contiene 
 * el menu principal de la aplicacion que donde existen
 * varias opciones con las que el usuario interactua, ademas la opcion de salir del sistema. 
 * 
 */
    public partial class FRMMenuPrincipal : Form
    {
        //atributos y referencias
        FRMFinca miFRMFinca;
        FRMListaFincas miFRMListaFincas;
        public FRMMenuPrincipal()
        {
            InitializeComponent();
        }//fin constructor

        /*
         * este metodo se acciona al dar click y despliega un nuevo formulario = Registrar Finca
         */
        private void fincaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instancia de formulario Registrar Finca
            this.miFRMFinca = new FRMFinca();
            this.miFRMFinca.Show();
        }//fincaToolStripMenuItem_Click
        /*
         * este metodo se encarga cerrar o no la aplicacion
         */
        private void FRMMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(cerrarFormulario);
            
        }//Finca_Load

        /*
         * este metodo se encarga de cerrar o no el formulario actual 
         */
        private void cerrarFormulario(object sender, FormClosingEventArgs e)
        {
            //preguntar a usuario si desea cerrar la aplicacion
            DialogResult respuesta = MessageBox.Show("Desea Salir de la Aplicacion", "Agroganadera Mi Finca",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (respuesta == DialogResult.OK)
            {
                System.Environment.Exit(0);
            }//fin if cerrar
            else
            {
                e.Cancel = true;
            }//fin else cerrar
        }//fin cerrarFormulario

        /*
         * este metodo se acciona al dar click sobre el menu strip mostrar fincas
         * y se encarga de desplegar en una tabla la informacion de los registros
         * Fincas
         */
        private void fincasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.miFRMListaFincas = new FRMListaFincas();
            this.miFRMListaFincas.Show();
        }//fin fincasToolStripMenuItem_Click
    }//fin clase parcial MenuPrincipal
}
