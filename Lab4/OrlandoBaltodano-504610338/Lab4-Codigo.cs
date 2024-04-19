using Lab4.OrlandoBaltodano_504610338;
using Lab4.OrlandoBaltodano_504610338.Productos;


ContenedorOrlando<Vehiculos> miContenedor = new Lab4.OrlandoBaltodano_504610338.ContenedorOrlando<Vehiculos>();
ContenedorOrlando<Frutas> otroContenedor = new Lab4.OrlandoBaltodano_504610338.ContenedorOrlando<Frutas>();
Vehiculos automovil = new Vehiculos("car");
Vehiculos camiones = new Vehiculos("Truck");
Frutas Sandia = new Frutas("Manzana");
Frutas fresas = new Frutas("Sandia");
miContenedor.Agregar(automovil);
miContenedor.Agregar(camiones);

otroContenedor.Agregar(Sandia);
otroContenedor.Agregar(fresas);


miContenedor.MostrarElementos();
otroContenedor.MostrarElementos();