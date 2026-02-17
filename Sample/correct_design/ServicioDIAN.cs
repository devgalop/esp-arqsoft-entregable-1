namespace Sample.correct_design;
public sealed class ServicioDIAN : IValidadorDocumento
{
    public bool Validar(Factura factura)
    {
        // Lógica para validar la factura con la DIAN
        Console.WriteLine("Validando factura con la DIAN...");
        return true; // Simulación de validación exitosa
    }

}