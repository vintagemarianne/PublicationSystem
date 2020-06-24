
using System;
using System.Collections.Generic;

namespace PublicationSystem.Models
{
    public class Book
    {
        public int Id { set; get; }

        public string Name { set; get; }
    }

    class Order
    {
         public Guid Id { get;  set;  }
         public DateTimeOffset OrderDateTime { get; set;  }
         public DateTimeOffset? DueDateTime { get; set; }
         public string OwnerName { get; set; }
         public string OwnerPhone { get; set; }
         public List<OrderItem> OrderItems { get; set; }
    }

    public class OrderItem
    {
        public Guid Id { get; set; }
        public ServiceType ServiceType { get; set; }
        public string CopySourceInfo { get; set; }
        public Publication Publication { get; set; }
    }
    

    public enum ServiceType
    {
        Copy,
        PrintPublication
    }

    public class Publication
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Isbn { get; set; }
        public int? Price { get; set; }
    }
}
