using System.Linq;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using PublicationSystem.Data;
using PublicationSystem.Models;
using PublicationSystem.Services;

namespace PublicationSystem.Pages
{
    public partial class BookDetail
    {
        [Inject]
        public BookService BookService { get; set; }

        [Inject]
        public PublicationDbContext Db { get; set; }

        [Parameter]
        public int BookId { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            var ordersQuery =
                from order in Db.Set<Order>()
                where order.TotalPrice < 10_000
                select order;

            var orders = ordersQuery.ToList();
        }
    }
}
