using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_10_ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado_por_comision e = new Empleado_por_comision("Karol Argeñal", "16-73775-2", 5000.0M, .04M);
            // muestra en pantalla los datos del empleado por comisión con salario base
            Console.WriteLine(e.ToString());
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
