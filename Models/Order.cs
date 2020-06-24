using System;
using System.Collections.Generic;

namespace PublicationSystem.Models
{
    public class Order
    {
        public Guid Id { get;  set;  }
        public DateTimeOffset OrderDateTime { get; set;  }
        public DateTimeOffset? DueDateTime { get; set; }
        public string OwnerName { get; set; }
        public string OwnerPhone { get; set; }
        public string OwnerAddress { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int TotalPrice { get; set; }
    }
}