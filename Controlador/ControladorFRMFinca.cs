using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace AgroganaderaMiFincaGui
{
    /*
     * esta clase se encarga de controlar las funciones entre la vista y los formularios
     * de finca
     */
    static class ControladorFRMFinca
    {
        //atributos y referencias
        static int posicion;static ObjetoFinca miObjetoFinca;
        public static List<ObjetoFinca> miListaFinca = new List<ObjetoFinca>();

        //metodos
        /*
         * este metodo se encarga de registrar objeto finca
         */
        public static string RegistrarFinca(ObjetoFinca miObjetoFinca)
        {
            string salida = "";
            miListaFinca.Add(miObjetoFinca);
            salida = "Se agrego la finca correctamente";
            return salida;// + "\n" + this.GuardarEnJson(miObjetoFinca);
        }//fin RegistrarFinca

        /*
         * BuscarNumeroFinca = se encarga de verificar si existe o no un objeto finca en 
         * el registro
         */
        public static  bool BuscarNumeroFinca(int numeroFinca)
        {

            bool encontrado = false;

            for (int i = 0; i < miListaFinca.Count; i++)
            {
                if (miListaFinca.ElementAt(index: numeroFinca).Equals(numeroFinca))
                {
                    encontrado = true;
                    miObjetoFinca = miListaFinca.ElementAt(index: numeroFinca);//objetoFinca
                    posicion = i;
                }//fin if verdad
            }//fin

            return encontrado;

        }//fin BuscarNumeroFinca
        /*
         * GetObjetoFinca = devuelve un objeto Finca con sus valores respectivos
         */
        public static ObjetoFinca GetObjetoFinca(int numeroFinca, string nombreFinca, string direccionFinca, int telefonoFinca, double tamanoFinca)
        {
            miObjetoFinca = new ObjetoFinca(numeroFinca, nombreFinca, direccionFinca, telefonoFinca, tamanoFinca);
            return miObjetoFinca;
        }//fin GetLlenarObjetoFinca

    }//fin clase ControladorFRMFinca
}
