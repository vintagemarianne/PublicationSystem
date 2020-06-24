using System;
using System.ComponentModel.DataAnnotations;

namespace PublicationSystem.Models
{
    public class Publication
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [MaxLength(30)]
        public string Isbn { get; set; }
        public string Author { get; set; }
        public int? Price { get; set; }
    }
}