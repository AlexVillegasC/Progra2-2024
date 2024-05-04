namespace Lab1.BrendaEspinoza;

public abstract class Pokemon{  
    public int Vida { get; set;}
    public int Ataque { get; set;}
    public string Nombre { get; set;}
 public Pokemon(int ataque, int vida, string Nombre)
    {
        this.Vida = vida;
        this.Ataque = ataque;
        this.Nombre = Nombre;
    }

    public void Danio(int danio){
        this.Vida -= danio;
    }

    public bool EstaVivo(){
       return this.Vida > 0;
    }

    public abstract string AtaqueEspecial();
}
//hi