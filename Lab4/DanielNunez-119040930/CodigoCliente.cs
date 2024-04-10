using Lab4.DanielNunez_119040930;

ContenedorDaniel<Piezas> miContenedorDeWish = new Lab4.DanielNunez_119040930.ContenedorDaniel<Piezas>();
Piezas peon = new Piezas("Peon");
Piezas dama = new Piezas("Dama");
miContenedorDeWish.Agregar(peon);
miContenedorDeWish.Agregar(dama);
miContenedorDeWish.MostrarElementos();