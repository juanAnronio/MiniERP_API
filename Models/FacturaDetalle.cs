namespace MiniERP_API.Models
{
    public class FacturaDetalle
    {
        public int Id { get; set; }

        public int FacturaId { get; set; }
        public int ProductoId { get; set; }
        public Factura? Factura { get; set; }
        public Producto? Producto { get; set; }

        public int Cantidad { get; set; }

        public decimal Subtotal => Producto != null ? Producto.Precio * Cantidad : 0;
    }
}
