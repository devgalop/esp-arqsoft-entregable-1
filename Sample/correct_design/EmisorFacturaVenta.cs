namespace Sample.correct_design;
public sealed class EmisorFacturaVenta(
    IValidadorDocumento validador
) : IEmisorFactura
{
    public bool Emitir(Factura factura)
    {
        // Lógica para emitir una factura de venta
        Console.WriteLine("Emitiendo Factura de Venta...");
        validador.Validar(factura);
        return true;
    }
}