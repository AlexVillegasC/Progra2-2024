namespace Lab2.JhonnRojas_703090697
{
    public class Carro : Medio_de_Transporte
    {


        public string Motor_combustion { get; set; }

        public Carro(string Marca, string Color, int Matricula, string Equilibrio_dinamico, string Motor_combustion)
               : base(Marca, Color, Matricula, Equilibrio_dinamico)
        {
            this.Motor_combustion = Motor_combustion;
        }

        public override void Realizar_mantenimiento()
        {
            Console.WriteLine("Verificar frenos, sistema de refrigeracion y suspencion");

        }


    }
}


