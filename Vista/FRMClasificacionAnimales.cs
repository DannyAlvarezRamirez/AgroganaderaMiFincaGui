using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//autor: Dany Esteban Alvarez Ramirez
namespace AgroganaderaMiFincaGui.Vista
{
    /*
     * esta clase se encarga de desplegar la interfaz de usuario para 
     * donde se visualizan los animales y su respectiva clasificacion segun macho o hembra
     */
    public partial class FRMClasificacionAnimales : Form
    {
        public FRMClasificacionAnimales()
        {
            InitializeComponent();
            LlenarDataGridViewAnimales();
        }//fin constructor

        //metodos
        /*
         * LlenarDataGridViewAnimales = este metodo se encarga de llenar el dataGridViewAnimales
         * con sus respectivos registros de animales
         */
        public void LlenarDataGridViewAnimales()
        {
            try
            {
                this.dataGridViewAnimales.DataSource = ControladorFRMAnimal.miListaAnimal;
            }//fin try
            catch (Exception ex)
            {
                MessageBox.Show("Aun no hay razas y/o fincas registradas.");
            }//fin catch
        }//fin LlenarDataGridViewAnimales

        /*
         * LlenarDataGridViewMachos = este metodo se encarga de llenar el dataGridViewMachos
         * con sus respectivos registros de animales machos
         */
        public void LlenarDataGridViewMachos()
        {
            try
            {
                //
                //this.dataGridViewMachos.DataSource = ControladorFRMAnimal.miListaAnimal;
            }//fin try
            catch (Exception ex)
            {
                MessageBox.Show("Aun no hay razas y/o fincas registradas.");
            }//fin catch
        }//fin LlenarDataGridViewMachos

        /*
         * LlenarDataGridViewHembras = este metodo se encarga de llenar el dataGridViewHembras
         * con sus respectivos registros de animales hembras
         */
        public void LlenarDataGridViewHembras()
        {
            try
            {
                //
                //this.dataGridViewHembras.DataSource = ControladorFRMAnimal.miListaAnimal;
            }//fin try
            catch (Exception ex)
            {
                MessageBox.Show("Aun no hay razas y/o fincas registradas.");
            }//fin catch
        }//fin LlenarDataGridViewHembras

        /*
         * este metodo se encarga de esconder el formulario actual
         */
        private void FRMClasificacionAnimales_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarFormulario);
        }//fin FRMClasificacionAnimales_Load

        /*
         * este metodo se encarga de esconder el formulario actual  
         */
        private void cerrarFormulario(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }//fin cerrarFormulario

        /*
         * este metodo se encarga de esconder el formulario Registrar Dueno
         */
        private void buttonIrAlMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }//fin buttonIrAlMenuPrincipal_Click

        /*
         * este metodo se encarga de clasificar los animales en dos secciones:
         * machos y hembras
         */
        private void buttonClasificacion_Click(object sender, EventArgs e)
        {

        }//fin buttonClasificacion_Click
    }//fin clase FRMClasificacionAnimales
}
