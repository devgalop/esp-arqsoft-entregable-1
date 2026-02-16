using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.bad_design;

public enum TipoFactura
{
    POS,
    VENTA,
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

    public bool Emitir()
    {
        return _tipoFactura switch
        {
            TipoFactura.VENTA => EmitirFacturaVenta(),
            TipoFactura.POS => EmitirFacturaPOS(),
            TipoFactura.DOCUMENTO_EQUIVALENTE => EmitirDocumentoEquivalente(),
            _ => throw new InvalidOperationException("Tipo de factura no soportado")
        };
    }

    private bool EmitirFacturaVenta()
    {
        ServicioDIAN dian = new ServicioDIAN();
        //lógica para emitir factura de venta
        return dian.Validar(this);
    }

    private bool EmitirFacturaPOS()
    {
        ServicioDIAN dian = new ServicioDIAN();
        //lógica para emitir factura POS
        return dian.Validar(this);
    }

    private bool EmitirDocumentoEquivalente()
    {
        ServicioDIAN dian = new ServicioDIAN();
        //lógica para emitir documento equivalente
        return dian.Validar(this);
    }

}