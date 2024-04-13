
namespace Lab3.OrlandoBaltodano;

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
public class Bennet : IHabilidadDefinitiva, IHabilidadElemental
=======
public class Bennet : IHabilidadDefinitiva , IHabilidadElemental
>>>>>>> e45abd7 ([lab3] Orlando-Baltodano)
=======
public class Bennet : IHabilidadDefinitiva, IHabilidadElemental
>>>>>>> 2550663 (Merge with latest Dev changes)
=======
public class Bennet : IHabilidadDefinitiva , IHabilidadElemental
>>>>>>> e45abd7 ([lab3] Orlando-Baltodano)
=======
public class Bennet : IHabilidadDefinitiva, IHabilidadElemental
>>>>>>> 2550663 (Merge with latest Dev changes)
{
    public string Nombre { get; set; }
    public int Vida { get; set; }

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    protected Bennet(string nombre, int vida)
=======
    protected Bennet(string nombre,int vida) 
>>>>>>> e45abd7 ([lab3] Orlando-Baltodano)
=======
    protected Bennet(string nombre, int vida)
>>>>>>> 2550663 (Merge with latest Dev changes)
=======
    protected Bennet(string nombre,int vida) 
>>>>>>> e45abd7 ([lab3] Orlando-Baltodano)
=======
    protected Bennet(string nombre, int vida)
>>>>>>> 2550663 (Merge with latest Dev changes)
    {
        this.Nombre = nombre;
        this.Vida = vida;
    }

    public void AtaqueElemental()
    {
        throw new NotImplementedException();
    }

    public void Ataque_Definitivo()
    {
        throw new NotImplementedException();
    }
}
