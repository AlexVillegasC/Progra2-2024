

namespace Lab2.DianaCerdas_504600379
{
    public abstract class Carro : Vehiculo
    {

        public override void Conducir()
        {
            Console.WriteLine("conduciendo");
        }

        public override void Arreglar()
        {
            Console.WriteLine("El carro esta en reparacion ");
        }

    }
}
