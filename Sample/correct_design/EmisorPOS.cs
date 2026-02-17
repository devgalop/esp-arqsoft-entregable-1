namespace Sample.correct_design;
public sealed class EmisorPOS(
    IValidadorDocumento validador
) : IEmisorFactura
{
    public boool Emitir(Factura factura)
    {
        // Lógica para emitir una factura POS
        Console.WriteLine("Emitiendo Factura POS...");
        validador.Validar(factura);
        return true;
    }
}