namespace SIOMS.Domain.Entities
{
    public class WarehouseProduct : BaseEntity
    {
        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; } = null!;

        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public int Quantity { get; set; }
    }
}
