using System;
namespace Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitesInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
