using EsentaSMS.Data.Models;
using EsentaSMS.Repository;
using EsentaSMS.Services.Interface;

namespace EsentaSMS.Services
{
    public class OrganisationService : IOrganisationService
    {
        private readonly IOrganisationRepository OrganisationRepository;

        public OrganisationService(IOrganisationRepository _OrganisationRepository)
        {
            OrganisationRepository = _OrganisationRepository;
        }

        public async Task AddOrganisationAsync(Organisation organisation)
        {
            await OrganisationRepository.AddOrganisation(organisation);
        }

        public async Task DeleteOrganisationAsync(int Id)
        {
            await OrganisationRepository.DeleteOrganisation(Id);
        }

        public async Task EditOrganisationAsync(Organisation organisation)
        {
            await OrganisationRepository.UpdateOrganisation(organisation);
        }

        public async Task<IEnumerable<Organisation>> GetAllOrganisationAsync()
        {
            return await OrganisationRepository.GetOrganisation();
        }
       
        public async Task<Organisation> GetOrganisationByIdAsync(int Id)
        {
            return await OrganisationRepository.GetOrganisationById(Id);
        }

    }
}
