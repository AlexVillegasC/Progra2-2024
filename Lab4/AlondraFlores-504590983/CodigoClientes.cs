using Lab4.AlondraFlores_504590983.Alimentos;
using Lab4.AlondraFlores_504590983;

McDonal<Bebidas> Restaurante = new Lab4.AlondraFlores_504590983.McDonal<Bebidas>();

Bebidas TeFrio = new Bebidas("Te Frio");
Bebidas Agua = new Bebidas("Agua");
Restaurante.Agregar(TeFrio);
Restaurante.Agregar(Agua);
Restaurante.MostrarMenu();

McDonal<Combos> Rest = new Lab4.AlondraFlores_504590983.McDonal<Combos>();

Combos Hamburguesa = new Combos("Hamburguesa");
Combos Papas = new Combos("Papas Fritas");
Rest.Agregar(Papas);
Rest.Agregar(Hamburguesa);
Restaurante.MostrarMenu();





   

