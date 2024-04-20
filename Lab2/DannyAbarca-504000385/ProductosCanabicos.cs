namespace Lab2.DannyAbarca;
    public abstract class ProductosCanabicos
    {
        public string NombreArticulo { get; set; }

        public int NivelTHC { get; set; }

        public int NivelCBD { get; set; }

        public int Precio { get; set; }


        protected ProductosCanabicos (string NombreArticulo, int NivelTHC,  int NivelCBD, int Precio)
        {

            this.NombreArticulo = NombreArticulo;
            this.NivelTHC = NivelTHC;
            this.NivelCBD = NivelCBD;
            this.Precio = Precio;

        }

        public abstract void TipodeArticulo();

        public virtual void Entrada()
        {
            Console.WriteLine("<-----Bienvenido a Canabi´s Store------>");
            Console.WriteLine("Aqui podras encontrar todo tipo de articulos a base de canabis y canabis misma");
        }
    }

