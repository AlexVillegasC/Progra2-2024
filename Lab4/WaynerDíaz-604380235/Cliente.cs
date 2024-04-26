namespace Lab4.WaynerDiaz;

public class Cliente
{
    public string Nombre { get; set; }
    public string Email { get; set; }

    public Cliente(string nombre, string email)
    {
        Nombre = nombre;
        Email = email;
    }
}

