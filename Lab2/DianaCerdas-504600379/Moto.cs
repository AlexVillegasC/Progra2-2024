

namespace Lab2.DianaCerdas_504600379
{
    public abstract class Moto : Vehiculo
    {
        public override void Conducir()
        {
            Console.WriteLine("acelerando");
        }

        public override void Arreglar()
        {
            Console.WriteLine(" la moto esta en reparacion ");
        }
    }
}
