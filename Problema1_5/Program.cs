
using Problema1_5.Data;
using Problema1_5.Entities;
using Problema1_5.Services;

ArticuloService articuloService = new ArticuloService();
FormaPagoService formaPagoService = new FormaPagoService();
FacturaService facturaService = new FacturaService();

Articulo articulo1 = new Articulo();
articulo1.Nombre = "Danonino";
articulo1.PrecioUnitar = 500;

articuloService.Save(articulo1);

List<Articulo> listArticulos = articuloService.GetAll();
foreach (var item in listArticulos)
{
    Console.WriteLine(item.ToString());
}

FormaPago formaPago1 = new FormaPago();
formaPago1.Nombre = "Efectivo";

formaPagoService.Save(formaPago1);

List<FormaPago> listFormasPago = formaPagoService.GetAll();
foreach (var item in listFormasPago)
{
    Console.WriteLine(item.ToString());
}


Factura factura1 = new Factura();
factura1.Fecha = DateTime.Now;
factura1.FormaPagoId = listFormasPago[0].Id;
factura1.FormaPago = listFormasPago[0];
factura1.Cliente = "Lionel Messi";

factura1.AgregarDetalle(listArticulos[0], 2);
factura1.AgregarDetalle(listArticulos[0], 3);



facturaService.Save(factura1);

List<Factura> listFacturas = facturaService.GetAll();

foreach (var item in listFacturas)
{
    Console.WriteLine(item.ToString());
}

var facturaById = facturaService.GetById(listFacturas[listFacturas.Count - 1].Id);

Console.WriteLine(facturaById.ToString());