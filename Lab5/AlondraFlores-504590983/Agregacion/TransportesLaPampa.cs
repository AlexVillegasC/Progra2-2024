namespace Lab5.AlondraFlores_504590983.Agregacion;

public class TransportesLaPampa
{
    public List<Vehiculo> vehiculos { get; set;}

    public TransportesLaPampa()
    {
        vehiculos = new List<Vehiculo>();
    }

    public void AgregarVehiculo(Vehiculo vehiculo)
    {
        vehiculos.Add(vehiculo);
    }
}
