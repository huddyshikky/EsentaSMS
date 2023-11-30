using EsentaSMS.Data.Models;
using EsentaSMS.Repository;
using EsentaSMS.Services.Interface;

namespace EsentaSMS.Services
{
    public class OrganisationService(IOrganisationRepository _OrganisationRepository) : IOrganisationService
    {
        private readonly IOrganisationRepository OrganisationRepository = _OrganisationRepository;

        public async Task<Organisation?> AddOrganisationAsync(Organisation organisation)
        {
            return await OrganisationRepository.AddOrganisation(organisation);
        }

        public async Task DeleteOrganisationAsync(int Id)
        {
            await OrganisationRepository.DeleteOrganisation(Id);
        }

        public async Task<Organisation> UpdateOrganisationAsync(Organisation updatedOrganisation)
        {
            return await OrganisationRepository.UpdateOrganisation(updatedOrganisation);
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
