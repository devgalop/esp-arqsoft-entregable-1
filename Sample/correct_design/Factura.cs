using System.Collections.Generic;

namespace Sample.correct_design;

public enum TipoFactura
{
    VENTA,
    POS,
    DOCUMENTO_EQUIVALENTE
}
public class Factura(TipoFactura tipoFactura)
{
    private readonly TipoFactura _tipoFactura = TipoFactura;
    private List<DetalleFactura> _detalles = [];

    public void AgregarDetalle(DetalleFactura detalle)
    {
        _detalles.Add(detalle);
    }

    public TipoFactura Tipo => _tipoFactura;

    private float CalcularTotal()
    {
        float total = 0;
        foreach (var detalle in Detalles)
        {
            total += detalle.Subtotal;
        }
        return total;
    }
}