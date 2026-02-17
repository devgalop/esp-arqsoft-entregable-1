namespace Sample.correct_design;

public sealed class EmisorDocumentoEquivalente(
    IValidadorDocumento validador
) : IEmisorFactura
{
    public bool Emitir(Factura factura)
    {
        // Lógica para emitir un documento equivalente
        Console.WriteLine("Emitiendo documento equivalente...");
        validador.Validar(factura);
        return true;
    }
}