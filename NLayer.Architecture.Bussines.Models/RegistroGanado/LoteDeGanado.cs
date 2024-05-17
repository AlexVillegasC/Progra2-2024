using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Architecture.Bussines.Models.RegistroGanado
{
    public class LoteDeGanado
    {
        public string Nombre { get; set; } = "Mi Reporte de Gestion de Ganado";
        public string Id { get; set; }
        public string Ubicacion { get; set; }

        public List<RegistroGanado> listaGanado {set; get; }

        public List<Registro_de_Vacunas> listaGanadoVacunas {set; get; }

        public List<RegistroVeterinario> ListaRegistroVet {set; get; }

    }
}

