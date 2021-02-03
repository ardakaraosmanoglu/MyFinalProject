using System;
using Entities.Abstrack;

namespace Entities
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitesInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
