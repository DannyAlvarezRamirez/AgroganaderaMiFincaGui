using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

//autor: Dany Esteban Alvarez Ramirez
namespace AgroganaderaMiFincaGui
{
    /*
     * esta clase se encarga de desplegar la interfaz de usuario para 
     * donde se visualizan los animales y su respectiva clasificacion segun macho o hembra
     */
    public partial class FRMClasificacionAnimales : Form
    {
        //atributos y referencias
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
                //lista temporal animales machos
                List<ObjetoAnimal> miListaAnimalesMachos = new List<ObjetoAnimal>();
                //llenar datagridviewMachos
                //recorrer la lista con la que se llena el datagridviewanimales
                for (int i = 0; i < ControladorFRMAnimal.miListaAnimal.Count; i++)
                {
                    if (ControladorFRMAnimal.miListaAnimal.ElementAt(i).SexoAnimal.Equals("Macho"))
                    {
                        miListaAnimalesMachos.Add(ControladorFRMAnimal.miListaAnimal.ElementAt(i));
                        //this.dataGridViewAnimales.Rows.RemoveAt(i);
                    }//fin if

                }//fin for

                //llenar datagridviewmachos
                this.dataGridViewMachos.DataSource = miListaAnimalesMachos;

                //await Task.Delay(5);
                ////eliminar del datagridviewanimales los sexo macho
                //for (int i = 0; i < this.dataGridViewAnimales.RowCount; i++)
                //{
                //    if (this.dataGridViewAnimales.Rows[i].Cells[1].Value.ToString().Equals("Macho"))
                //    {
                //        this.dataGridViewAnimales.Rows.RemoveAt(i);
                //    }//fin if
                //}//fin for

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
                //lista temporal animales hembra
                List<ObjetoAnimal> miListaAnimalesHembras = new List<ObjetoAnimal>();

                //llenar datagridviewhembras
                //recorrer la lista con la que se llena el datagridviewanimales
                for (int i = 0; i < ControladorFRMAnimal.miListaAnimal.Count; i++)
                {
                    if (ControladorFRMAnimal.miListaAnimal.ElementAt(i).SexoAnimal.Equals("Hembra"))
                    {
                        miListaAnimalesHembras.Add(ControladorFRMAnimal.miListaAnimal.ElementAt(i));
                        //this.dataGridViewAnimales.Rows.RemoveAt(i);
                    }//fin if

                }//fin for
                //llenar datagridviewhembras
                this.dataGridViewHembras.DataSource = miListaAnimalesHembras;

                //await Task.Delay(5);
                ////eliminar del datagridviewanimales los sexo hembra
                //for (int i = 0; i < this.dataGridViewAnimales.RowCount; i++)
                //{
                //    if (this.dataGridViewAnimales.Rows[i].Cells[1].Value.ToString().Equals("Hembra"))
                //    {
                //        this.dataGridViewAnimales.Rows.RemoveAt(i);
                //    }//fin if
                //}//fin for

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
        private async void buttonClasificacion_Click(object sender, EventArgs e)
        {
            try
            {
                LlenarDataGridViewMachos();
                await Task.Delay(10);
                LlenarDataGridViewHembras();
                await Task.Delay(3);
                this.dataGridViewAnimales.DataSource = null;
            }//fin try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }//fin catch
            
        }//fin buttonClasificacion_Click
    }//fin clase FRMClasificacionAnimales
}
