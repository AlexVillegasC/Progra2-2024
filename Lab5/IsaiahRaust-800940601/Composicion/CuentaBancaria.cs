namespace Lab5.IsaiahRaust_800940601.Composicion;


public class CuentaBancaria
{
    public Titular Titular { get; set; }
    public Transaccion Transaccion { get; set; }

    public CuentaBancaria()
    {
        Titular = new Titular();
        Transaccion = new Transaccion();
    }
}
