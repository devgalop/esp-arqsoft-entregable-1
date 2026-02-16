using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.bad_design
{
    public sealed class ServicioDIAN
    {
        public bool Validar(Factura factura)
        {
            // Lógica de validación con la DIAN
            Console.WriteLine($"Validando factura con la DIAN...");
            return true; // Simulación de validación exitosa
        }
    }
}