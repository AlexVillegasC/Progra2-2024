using Lab4.DiegoGutierrez_504560809.Objetos;
using Lab4.DiegoGutierrez_504560809;

ContenedorDiego<Pokeballs> contenedor = new Lab4.DiegoGutierrez_504560809.ContenedorDiego<Pokeballs>();
ContenedorDiego<Bayas> contenedor1 = new Lab4.DiegoGutierrez_504560809.ContenedorDiego<Bayas>();
ContenedorDiego<Mts> contenedor2 = new Lab4.DiegoGutierrez_504560809.ContenedorDiego<Mts>();

Pokeballs Pokeball = new Pokeballs("Pokeball");
Pokeballs Ultraball = new Pokeballs("Ultraball");
contenedor.AgregarObjetos(Pokeball);
contenedor.AgregarObjetos(Ultraball);

Bayas Caquic = new Bayas("Caquic");
Bayas Meloc = new Bayas("Meloc");
contenedor1.AgregarObjetos(Caquic);
contenedor1.AgregarObjetos(Meloc);

Mts Surf = new Mts("Surf");
Mts Lanzallamas = new Mts("Lanzallamas");
contenedor2.AgregarObjetos(Surf);
contenedor2.AgregarObjetos(Lanzallamas);

contenedor.MostrarObjetos();
contenedor1.MostrarObjetos();
contenedor2.MostrarObjetos();