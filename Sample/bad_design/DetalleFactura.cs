using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.bad_design;

/// <summary>
/// Representa el detalle de una factura
/// </summary>
/// <param name="producto">Producto seleccionado</param>
/// <param name="cantidad">Cantidad</param>
public class DetalleFactura(Producto producto, int cantidad)
{
    private readonly Producto _producto = producto;
    private readonly int _cantidad = cantidad;

    /// <summary>
    /// Calcula el subtotal del detalle sin aplicar impuestos
    /// </summary>
    /// <returns>Subtotal</returns>
    public float CalcularSubtotal()
    {
        return _producto.ObtenerPrecio() * _cantidad;
    }

    /// <summary>
    /// Calcula el total del detalle aplicando impuestos
    /// </summary>
    /// <returns>Subtotal con impuestos</returns>
    public float AplicarIVA()
    {
        return _producto.CalcularPrecioConImpuesto() * _cantidad;
    }
}