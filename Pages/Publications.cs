using Microsoft.AspNetCore.Components;
using PublicationSystem.Data;
using PublicationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicationSystem.Pages
{
    public partial class Publications
    {
        [Inject]
        public PublicationDbContext Db { get; set; }

        public IEnumerable<Publication> PublicationList { get; set; }

        protected override async Task OnInitializedAsync()
        {
            
            var publicationsQuery =
                from publication in Db.Set<Publication>()
                select publication;

            PublicationList = publicationsQuery.ToList();
            await base.OnInitializedAsync();
        }
    }
}
