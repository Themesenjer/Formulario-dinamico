namespace ProductosAPI.Models
{
    public class Producto
    {
        public int Id { get; set; }  // Clave primaria
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }
}
