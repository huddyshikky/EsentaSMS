

using EsentaSMS.Data.Models;

namespace EsentaSMS.Repository
{
    public interface IOrganisationRepository
    {
        Task<Organisation?> GetOrganisationById(int Id);
        Task<IEnumerable<Organisation?>> GetOrganisation();
        Task<Organisation?> AddOrganisation(Organisation organisation);
        Task<Organisation?> UpdateOrganisation(Organisation organisation);
        Task DeleteOrganisation(int Id);
    }
}
