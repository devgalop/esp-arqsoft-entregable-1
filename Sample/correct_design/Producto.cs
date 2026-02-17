namespace Sample.correct_design;
public record Producto(string Nombre, float Precio, float PorcentajeImpuesto)
{
    public float CalcularPrecioConImpuesto()
    {
        return Precio + (Precio * PorcentajeImpuesto);
    }

    public float ObtenerPrecio()
    {
        return Precio;
    }
}