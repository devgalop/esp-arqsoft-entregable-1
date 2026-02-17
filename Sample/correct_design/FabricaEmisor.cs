namespace Sample.correct_design
{
    public class FabricaEmisor
    {
        public IEmisorFactura CrearEmisor(Factura.TipoFactura tipoFactura)
        {
            return tipoFactura switch
            {
                TipoFactura.VENTA => new EmisorFacturaVenta(),
                TipoFactura.POS => new EmisorPOS(),
                TipoFactura.DOCUMENTO_EQUIVALENTE => new EmisorDocumentoEquivalente(),
                _ => throw new System.ArgumentException("Tipo de factura no soportado")
            };
        }
    }
}