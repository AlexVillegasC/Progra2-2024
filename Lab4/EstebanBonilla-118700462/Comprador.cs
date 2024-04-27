using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.EstebanBonilla_118700462;
public class Comprador
{
    public string Nombre { get; set; }
    public string Email { get; set; }

    public Comprador(string nombre, string email)
    {
        Nombre = nombre;
        Email = email;
    }
}
