


using Lab4.AlexVillegas_503990937;
using Lab4.AlexVillegas_503990937.Productos;

ContenedorAlexV<Muebles> miContenedorDeWish = new Lab4.AlexVillegas_503990937.ContenedorAlexV<Muebles>();
Muebles sillon = new Muebles("Sillon");
Muebles mesa = new Muebles("Mesa");
miContenedorDeWish.Agregar(sillon);
miContenedorDeWish.Agregar(mesa);


miContenedorDeWish.MostrarElementos();