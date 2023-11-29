

using EsentaSMS.Data.Models;

namespace EsentaSMS.Repository
{
    public interface IOrganisationRepository
    {
        Task<Organisation?> GetOrganisationById(int Id);
        Task<IEnumerable<Organisation?>> GetOrganisation();
        Task AddOrganisation(Organisation organisation);
        Task UpdateOrganisation(Organisation organisation);
        Task DeleteOrganisation(int Id);
    }
}
