using System;

public class API
{
    private Inventario inventario = new Inventario();

    public Inventario GetInventario()
    {
        return inventario;
    }

    public void AñadirSemilla(Semilla semilla)
    {
        inventario.AgregarRecurso(semilla);
    }

    public void AñadirFertilizante(Fertilizante fertilizante)
    {
        inventario.AgregarRecurso(fertilizante);
    }

    public void AñadirPesticida(Pesticida pesticida)
    {
        inventario.AgregarRecurso(pesticida);
    }

    public Recurso GetRecurso(int id)
    {
        return inventario.Find(r => r.Id == id);
    }
}