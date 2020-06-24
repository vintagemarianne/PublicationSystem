using Microsoft.AspNetCore.Components;
using PublicationSystem.Services;

namespace PublicationSystem.Pages
{
    public partial class BookDetail
    {
        [Inject]
        public BookService BookService { get; set; }

        [Parameter]
        public int BookId { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
        }
    }
}
