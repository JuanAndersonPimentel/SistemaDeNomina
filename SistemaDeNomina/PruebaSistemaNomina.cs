using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeNomina
{
    public class PruebaSistemaNomina
    {
        public static void Main(string[] args)

        {
            EmpleadoAsalariado empleadoAsalariado = new EmpleadoAsalariado( "jhon", "smith", "111-11-1111", 800.00M);
            EmpleadoPorHoras empleadoPorHoras = new EmpleadoPorHoras("karen", "price", "222-22-222", 40.0M);
            EmpleadosPorComision empleadosPorComision = new EmpleadosPorComision(" sue", "jones", "333-33-333", 10000.00M, .06M);
            EmpleadosBaseMasComision empleadosBaseMasComision = new EmpleadosBaseMasComision("Bob", "Lewis", "444-44-444", 5000.00M, .04M, 300.00M);

            Console.WriteLine("{0}\n{1}: {2:C}\n", empleadoAsalariado, "ingresos", empleadoAsalariado.Ingresos());
            Console.WriteLine("{0}\n{1}: {2:C}\n", empleadoPorHoras, "ingresos",empleadoPorHoras.Ingresos());
            Console.WriteLine("{0}\n{1}: {2:C}\n",empleadosPorComision, "ingresos", empleadosPorComision.Ingresos());
            Console.WriteLine("{0}\n{1}: {2:C}\n",
                empleadosBaseMasComision, "ingresos", empleadosBaseMasComision.Ingresos());
        }

        Empleado empleado = new Empleado();

        Empleados[ 0 ] = empleadoAsalariado;
        Empleados[ 1 ] = empleadoPorHoras;
        Empleados[ 2 ] = empleadoPorComision;
        Empleados[ 3 ] = empleadoBaseMasComision
            
       

    }
}
