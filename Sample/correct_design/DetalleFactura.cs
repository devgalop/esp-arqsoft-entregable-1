namespace Sample.correct_design;
public class DetalleFactura(Producto producto, int cantidad)
{
    private readonly Producto _producto = producto;
    private readonly int _cantidad = cantidad;

    public float CalcularSubtotal()
    {
        return _producto.ObtenerPrecio() * _cantidad;
    }

    public float AplicarIVA()
    {
        return _producto.CalcularPrecioConImpuesto() * _cantidad;
    }
}