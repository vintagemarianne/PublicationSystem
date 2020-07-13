using System;
using System.Threading.Tasks;
using PublicationSystem.Models;

namespace PublicationSystem.Services
{
    public interface IPublicationService
    {
        Task AddPublication(Publication publication);
        Task DeletePublicationAsync(Guid id);
        Task UpdatePublicationAsync(Publication publication);
    }
}