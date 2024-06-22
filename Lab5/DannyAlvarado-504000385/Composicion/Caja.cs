namespace Lab5.Danny_Alvarado_504000385.Composicion;

    public class Caja
    {
        public string Material { get; set; }
        public string Dimensions { get; set; }

        public Caja(string material, string dimensions)
        {
            Material = material;
            Dimensions = dimensions;
        }

        public override string ToString()
        {
            return $"Material: {Material}, Dimensions: {Dimensions}";
        }
    }


