using Lab5.AlexVillegas_503990937.Agregacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.AxelZuniga_504250653.agregacion
{
    public class Carro
    {
        public List<Llanta> Llantas { get; set; }

        public Carro()
        {
            Llantas = new List<Llanta>();
        }

        public void AgregarLlanta(Llanta llanta)
        {
            Llantas.Add(llanta);
        }

    }
}
