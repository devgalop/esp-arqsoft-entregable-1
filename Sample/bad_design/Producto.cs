using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.bad_design;

public record Producto(string Nombre, float Precio, float PorcentajeImpuesto)
{
    /// <summary>
    /// Calcula el precio del producto aplicando impuestos
    /// </summary>
    /// <returns>Precio con impuesto</returns>
    public float CalcularPrecioConImpuesto()
    {
        return Precio + (Precio * PorcentajeImpuesto);
    }

    /// <summary>
    /// Obtiene el precio del producto sin impuestos
    /// </summary>
    /// <returns>Precio antes de impuestos</returns>
    public float ObtenerPrecio()
    {
        return Precio;
    }
}