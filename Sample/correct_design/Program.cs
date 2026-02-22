using Sample.correct_design;

//Creacion de productos
Producto laptop = new Producto("PC-Portatil", 100m, 0.19m);
Producto gamer = new Producto("PC-Gamer", 500m, 0.12m);
Producto teclado = new Producto("Teclado", 100m, 0.15m);
Producto mouse = new Producto("Mouse", 100m, 0m);

//Creacion de Factura
Factura factura = new Factura(TipoFactura.VENTA);
//Agregamos detalles a la factura
factura.AgregarDetalle(new DetalleFactura(laptop, 1));
factura.AgregarDetalle(new DetalleFactura(gamer, 1));
factura.AgregarDetalle(new DetalleFactura(teclado, 2));
factura.AgregarDetalle(new DetalleFactura(mouse, 1));

//Creamos un emisor de factura
FabricaEmisor fabricaEmisor = new FabricaEmisor();
IEmisorFactura emisor = fabricaEmisor.CrearEmisor(factura.TipoFactura);

//Emitimos la factura
bool resultado = emisor.Emitir(factura);
Console.WriteLine($"Factura emitida con resultado: {resultado}");