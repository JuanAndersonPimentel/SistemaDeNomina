using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeNomina
{
    public class EmpleadoPorHoras 
    {
        private decimal sueldo;
        private decimal horas;

        public EmpleadoPorHoras( string nombre, string apellido,string nns, decimal sueldoPorHoras, decimal horasTabajadas ) : base( nombre, apellido, nns)
        {
            Sueldo = sueldoPorHoras;
            horas = horasTabajadas;
        }
        public decimal Sueldo
        {
            get
            {
                return sueldo;
            } 
            set
            {
                sueldo = (value >= 0) ? value : 0; 
            }
            
        }
        public decimal Horas
        {
            get
            {
                return horas;
            }
            set
            {
                horas = ( (value >= 0) && ( value <= 168) ) ? value : 0;
            }
        }
        public override decimal Ingresos()
        {
            if (Horas <= 40)
                return sueldo * horas;
            else 
                return ( 40 * sueldo ) + (Horas - 40) * sueldo * 1.5M );
        }
        public override string ToString()
        {
            return string.Format("empleado por horas: {0}\n{1}: {2:C}; {3}: {4:F2}", base.ToString(), "sueldo por horas", Sueldo, "horas trabajadas", Horas );
        }
    }
}
