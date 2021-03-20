using System;
using System.Collections.Generic;
using System.Text;

namespace AgroganaderaMiFincaGui
{
    class ObjetoEmpleado: ObjetoPersona
    {
        //atributos
        private double dbSalarioEmpleado;

        public ObjetoEmpleado(int identificacionPersona, string nombrePersona, string primerApellido, string segundoApellido, 
            double salarioEmpleado)
            :base(identificacionPersona, nombrePersona, primerApellido, segundoApellido)
        {
            this.dbSalarioEmpleado = salarioEmpleado;
        }//fin constructor con parametros

        //parametros
        //SalarioEmpleado
        public double SalarioEmpleado
        {
            set
            {
                this.dbSalarioEmpleado = value;
            }
            get
            {
                return this.dbSalarioEmpleado;
            }
        }//fin SalarioEmpleado
        //GetInformacionObjetoEmpleado
        public string GetInformacionObjetoEmpleado()
        {
            return "Información del empleado*\nIdentificacion = " + this.IdentificacionPersona + ", Nombre = " + this.NombrePersona + ", " +
                "Primer Apellido = " + this.PrimerApellidoPersona + ", Segundo Apellido = " + this.SegunoApellidoPersona + ", Salario = " + this.SalarioEmpleado;
        }//fin GetInformacionObjetoEmpleado
    }
}
