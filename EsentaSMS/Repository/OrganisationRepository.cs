

using EsentaSMS.Components.Account.Pages.Manage;
using EsentaSMS.Data;
using EsentaSMS.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;
namespace EsentaSMS.Repository
{
    public class OrganisationRepository(EsentaSMSContext SMSContext) : IOrganisationRepository
    {
        private readonly EsentaSMSContext db = SMSContext;

        public async Task<Organisation?> GetOrganisationById(int Id)
        {
            return await db.Organisations.FindAsync(Id);
        }

        public async Task<IEnumerable<Organisation?>> GetOrganisation()
        {
            return await db.Organisations.ToListAsync();
        }

        public async Task<Organisation?> AddOrganisation(Organisation organisation)
        {
            if (db.Organisations.Any(x => x.Name.ToLower().Equals(organisation.Name.ToLower()))) return null;
          

            db.Organisations.Add(organisation);
            await db.SaveChangesAsync();

            return organisation;    
        }

        public async Task<Organisation?> UpdateOrganisation(Organisation updatedOrganisation)
        {
             
            var existingOrganisation = await db.Organisations.FindAsync(updatedOrganisation.Id);    
            if (existingOrganisation != null)
            {
                existingOrganisation.Name = updatedOrganisation.Name;
                existingOrganisation.Address = updatedOrganisation.Address;
                existingOrganisation.Phone = updatedOrganisation.Phone;
                existingOrganisation.Email = updatedOrganisation.Email;
                existingOrganisation.City = updatedOrganisation.City;
                existingOrganisation.County = updatedOrganisation.County;
                existingOrganisation.Logo = updatedOrganisation.Logo;

                await db.SaveChangesAsync();
                return existingOrganisation;
            }
            return null;
        }


        public async Task DeleteOrganisation(int Id)
        {
            var foundDetails = await db.Organisations.FindAsync(Id);
            if (foundDetails != null)
            {
                db.Remove(foundDetails);
                await db.SaveChangesAsync();
            }
        }
    }
}
