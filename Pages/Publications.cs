using Microsoft.AspNetCore.Components;
using PublicationSystem.Data;
using PublicationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PublicationSystem.Services;

namespace PublicationSystem.Pages
{
    public partial class Publications
    {
        [Inject]
        public PublicationDbContext Db { get; set; }
        [Inject]
        public IPublicationService PublicationService { get; set; }

        public IEnumerable<Publication> PublicationList { get; set; }

        protected override async Task OnInitializedAsync()
        {
            
            var publicationsQuery =
                from publication in Db.Set<Publication>()
                select publication;

            PublicationList = publicationsQuery.ToList();
            await base.OnInitializedAsync();
        }

        public async Task AddPublicationAsync(Publication publication)
        {
            await PublicationService.AddPublication(publication);
        }

        public async Task DeletePublicationAsync(Guid id)
        {
            await PublicationService.DeletePublicationAsync(id);
        }

        public async Task UpdatePublicationAsync(Publication publication)
        {
            await PublicationService.UpdatePublicationAsync(publication);
        }
    }
}
