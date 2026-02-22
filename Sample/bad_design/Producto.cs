namespace Sample.bad_design;

public class Producto(string Nombre, decimal Precio, decimal PorcentajeImpuesto)
{
    private readonly string _nombre = Nombre;
    private readonly decimal _precio = Precio;
    private readonly decimal _porcentajeImpuesto = PorcentajeImpuesto;

    public decimal CalcularPrecioConImpuesto()
    {
        return _precio + (_precio * _porcentajeImpuesto);
    }

    public decimal ObtenerPrecio()
    {
        return _precio;
    }
}