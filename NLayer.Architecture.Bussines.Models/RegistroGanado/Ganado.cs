using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Architecture.Bussines.Models.RegistroGanado;

    public class Ganado
    {
        public string ID { get; set; }
        public DateTime Date{ get; set; }

        public string Nombre { get; set; }
        public float Peso { get; set; }

        public string Raza { get; set; }
    }

