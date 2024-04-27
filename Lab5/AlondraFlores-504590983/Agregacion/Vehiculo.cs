namespace Lab5.AlondraFlores_504590983.Agregacion;

public class Vehiculo
{
    public string Modelo { get; set;}
    public int Placa { get; set;}

    public Vehiculo(string modelo, int placa)
    {
        Modelo = modelo;
        Placa = placa;
    }

    public int Placas()
    {
        return Placa;
    }
}
