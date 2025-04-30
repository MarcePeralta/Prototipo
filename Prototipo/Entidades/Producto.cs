namespace Prototipo.Entities
{
    public class Producto
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Existencia { get; set; }
        public bool Descontinuada { get; set; }
    }
}
