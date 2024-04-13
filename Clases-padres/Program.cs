using Clases_padres.ClaseHija;

Nintendo nintendo = new Nintendo();
nintendo.anioLanzamiento = 2017;
nintendo.esPortable = true;
nintendo.Marca = "Switch";
Console.WriteLine(nintendo.MostrarDetalleNintendo());

PlayStation ps = new PlayStation();
ps.Marca = "Play Station 1";
ps.anioLanzamiento = 1994;
ps.ModeloCotrolador = "DualSense";
Console.WriteLine($"{ps.MostrarDetallePlay()}");

Xbox box = new Xbox();
box.GPU = "Graphics Core Next";

SegaDreamCast SEGA = new SegaDreamCast();
SEGA.CPU = "Hitachi SH-4 ";

