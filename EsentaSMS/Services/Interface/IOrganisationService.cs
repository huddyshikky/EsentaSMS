using EsentaSMS.Data.Models;

namespace EsentaSMS.Services.Interface
{
    public interface IOrganisationService
    {
        Task<Organisation?> AddOrganisationAsync(Organisation organisation);
        Task DeleteOrganisationAsync(int Id);
        Task<Organisation?> UpdateOrganisationAsync(Organisation updatedOrganisation);
        Task<Organisation?> GetOrganisationByIdAsync(int Id);
        Task<IEnumerable<Organisation>> GetAllOrganisationAsync();
    }
}
