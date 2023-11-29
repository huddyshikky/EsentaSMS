using EsentaSMS.Data.Models;

namespace EsentaSMS.Services.Interface
{
    public interface IOrganisationService
    {
        Task AddOrganisationAsync(Organisation organisation);
        Task DeleteOrganisationAsync(int Id);
        Task EditOrganisationAsync(Organisation organisation);
        Task<Organisation> GetOrganisationByIdAsync(int Id);
        Task<IEnumerable<Organisation>> GetAllOrganisationAsync();
    }
}
