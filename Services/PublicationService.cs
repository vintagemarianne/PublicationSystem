using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using PublicationSystem.Data;
using PublicationSystem.Models;
using Exception = System.Exception;

namespace PublicationSystem.Services
{
    public class PublicationService : IPublicationService
    {
        [Inject]
        public PublicationDbContext Db { get; set; }

        public async Task AddPublication(Publication publication)
        {
            Db.Set<Publication>().Add(publication);
            await Db.SaveChangesAsync();
        }

        public async Task DeletePublicationAsync(Guid id)
        {
            var publication = await Db.Set<Publication>().FirstOrDefaultAsync(p => p.Id == id);
            if (publication != null)
            {
                Db.Set<Publication>().Remove(publication);
                await Db.SaveChangesAsync();
            }
        }

        public async Task UpdatePublicationAsync(Publication publication)
        {
            var currentPublication = await Db.Set<Publication>().FirstOrDefaultAsync(p => p.Id == publication.Id);
            
            if (currentPublication != null)
            {
                currentPublication.Author = publication.Author;
                // ToDo: Copy all the items.

                await Db.SaveChangesAsync();
            }
            else
            {
                throw new Exception($"Unable to update publication: {publication.Id}");
            }
        }
    }
}
