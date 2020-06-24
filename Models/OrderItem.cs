using System;

namespace PublicationSystem.Models
{
    public class OrderItem
    {
        public Guid Id { get; set; }
        public Order Order { get; set; }
        public ServiceType ServiceType { get; set; }
        public string CopySourceInfo { get; set; }
        public Publication Publication { get; set; }
        public int? Amount { get; set; }
        public int? Fee { get; set; }
    }
}