using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //internal class --> sadece bulundugu katman erişir.(public zıttı)
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; } 
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
