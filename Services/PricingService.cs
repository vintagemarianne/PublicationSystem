using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using PublicationSystem.Data;
using PublicationSystem.Models;

namespace PublicationSystem.Services
{
    public class PricingService
    {
        [Inject]
        public PublicationDbContext Db { get; set; }
        [Inject]
        public IPublicationService PublicationService { get; set; }
        
        public async Task MakeExpensiveAsync()
        {
            var moreThan100PublicationsQuery =
                from p in Db.Set<Publication>()
                where p.Price > 100_000
                select p;

            var moreThan100Publications = await moreThan100PublicationsQuery.ToListAsync();

            foreach (var p in moreThan100Publications)
            {
                p.Price = (int)(p.Price.Value * 1.2);
                await PublicationService.UpdatePublicationAsync(p);
            }

            var lessThan100PublicationsQuery =
                from p in Db.Set<Publication>()
                where p.Price <= 100_000
                select p;

            var lessThan100Publications = await lessThan100PublicationsQuery.ToListAsync();

            foreach (var p in lessThan100Publications)
            {
                if (p.Price < 10_000)
                {
                    await PublicationService.DeletePublicationAsync(p.Id);
                }
                else
                {
                    p.Price = (int)(p.Price.Value * 1.1);
                    await PublicationService.UpdatePublicationAsync(p);
                }
            }

        }

        public void MakeCheap(IEnumerable<Publication> publications)
        {
            foreach (var publication in publications)
            {
                if (publication.Price >= 100_000)
                {
                    publication.Price = (int)(publication.Price.Value * .8);

                }

                else if (publication.Price < 100_000)
                {
                    publication.Price = (int)(publication.Price.Value * .9);

                }
            }
        }
    }
}
