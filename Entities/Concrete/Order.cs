using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //Veritabanından gelenleri Entities altında Concrete'de topla.
    public class Order : IEntity
    {
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime OrderTime{ get; set; }
        public string ShipCity { get; set; }

    }
}
