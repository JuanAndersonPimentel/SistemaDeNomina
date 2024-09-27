using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeNomina
{

    public abstract class Empleado
    {
        private string primerNombre;
        private string apellidoPaterno;
        private string numeroSeguroSocial;

        public Empleado (string Nombre, string apellido, string nss)
        {
            primerNombre = Nombre;
            apellidoPaterno = apellido;
            numeroSeguroSocial = nss;

        }
        public string PrimerNombre
        {
            get { return primerNombre; }

        }
        public string ApellidoPaterno
        {
            get  { return apellidoPaterno; }

        }
        public string NumeroSeguroSocial
        {
            get { return numeroSeguroSocial; }

        }
        public override string ToString()
        {
            return string.Format( "{0} {1}\numero de seguro social: {2}",primerNombre, ApellidoPaterno, NumeroSeguroSocial);
        }
        public abstract decimal ingresos();

        public class EmpleadoAsalariado : Empleado
        {
            private decimal salarioSemanal;

            public EmpleadoAsalariado(string Nombre, string apellido, string nss, decimal salario) : base(Nombre, apellido, nss)
            {
                salarioSemanal = salario;
            }
            public decimal SalarioSemanal
            {
                get
                { return salarioSemanal; }
             
                set
                {
                    salarioSemanal = (value  > 0) ? value : 0;
                }
            }
            public override decimal ingresos()
            {
                return salarioSemanal;
            }
            public override string ToString()
            {
                return string.Format("empleado asalariado: {0}\n{1}: {2:C}", base.ToString(), "salario semanal", SalarioSemanal);
            }

            


        }

             



        


    }


}
