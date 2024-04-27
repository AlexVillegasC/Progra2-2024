using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.AxelBadilla_504430558.Agregacion
{
    public class Universidad
    {


        public List<Departamento> departamentos = new List<Departamento>();

        public void Agregar_departamento(Departamento departamento)
        {

            departamentos.Add(departamento);
        }

        public void ImprimirDepartamento()
        {
            foreach (var materia in departamentos)
            {
                Console.WriteLine($"Nombre:{materia.Nombre}\n numero materia{materia.Codigo_materia}");
            }
        }
    }
}
//Universidad departamento=new Universidad();

//Universidad.Agregar_departamento();
//Universidad.ImprimirDepartamento();
