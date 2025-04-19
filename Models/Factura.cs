namespace MiniERP_API.Models
{
    public class Factura
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
        public DateTime Fecha { get; set; }

        public List<FacturaDetalle> Detalles { get; set; }

        public decimal Total => Detalles?.Sum(d => d.Subtotal) ?? 0;
    }
}
