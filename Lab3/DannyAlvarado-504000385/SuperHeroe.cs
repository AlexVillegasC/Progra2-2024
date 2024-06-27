namespace Lab3.DannyAlvarado_504000385
{
    public class Superheroe : PoderJumper, PoderVisionRayosX, PoderVolar
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Salud { get; set; }

        public Superheroe(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
            Salud = 100; // Salud inicial
        }
        public void SuperPoderJumper()
        {
            throw new NotImplementedException();
        }

        public void SuperPoderVisionRayosX()
        {
            throw new NotImplementedException();
        }

        public void SuperPoderVolar()
        {
            throw new NotImplementedException();
        }
    }
}
