﻿
namespace Lab5.ArianaHernandez_504520730.Agregación
{
    public class Océano
    {
        public List<Cetaceos> Cetaceos { get; set; }
        public List<Peces> Peces { get; set; }

        public Océano()
        {
            Cetaceos = new List<Cetaceos>();
            Peces = new List<Peces>();

        }

        public void AgregarPeces(Peces peces)
        {
            Peces.Add(peces);
        }
        public void AgregarCetaceos(Cetaceos cetaceos)
        {
            Cetaceos.Add(cetaceos);
        }
    }
}
