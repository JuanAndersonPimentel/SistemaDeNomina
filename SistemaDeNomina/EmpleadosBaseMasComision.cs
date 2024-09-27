using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeNomina
{
    public class EmpleadosBaseMasComision
    {
        private decimal salarioBase;
    }
    public EmpleadosBaseMasComision(string nombre, string apellido, string nss, decimal ventas, decimal tarifa, decimal salario) : base(nombre, apellido, nss, ventas, tarifa)
    {
        SalarioBase = salario;

    }
    public decimal SalarioBase
    {
        get
        {
            return SalarioBase;
        }
        set
        {
            SalarioBase = (value >= 0) ? value : 0;
        }

    }
    public override decimal Ingresos()
    {
        return SalarioBase + base.Ingresos();
    }
    public override string ToString()
    {
        return string.Format("{10} {1}; {2}: {3:C}", "salario base +", base.ToString(); "salario base", SalarioBase );
    }
    
}
