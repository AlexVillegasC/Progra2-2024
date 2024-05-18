using System;

using System;
using System.Collections.Generic;

public class Inventario
{
    private List<Recurso> recursos = new List<Recurso>();

    public void AgregarRecurso(Recurso recurso)
    {
        recursos.Add(recurso);
    }

    public void EliminarRecurso(int id)
    {
        recursos.RemoveAll(r => r.Id == id);
    }

    public void ActualizarCantidad(int id, int cantidad)
    {
        var recurso = recursos.Find(r => r.Id == id);
        if (recurso != null)
        {
            recurso.Cantidad = cantidad;
        }
    }
}