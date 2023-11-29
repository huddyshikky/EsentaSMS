

using EsentaSMS.Components.Account.Pages.Manage;
using EsentaSMS.Data;
using EsentaSMS.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;
namespace EsentaSMS.Repository
{
    public class OrganisationRepository : IOrganisationRepository
    {
        private readonly EsentaSMSContext db;

        public OrganisationRepository(EsentaSMSContext SMSContext)
        {
            db = SMSContext;
        }

        public async Task<Organisation?> GetOrganisationById(int Id)
        {
            var FoundOrganisation = await db.Organisations.FindAsync(Id);
            if (FoundOrganisation == null) return FoundOrganisation;

            Organisation RetOrg = new()
            {
                Id = FoundOrganisation.Id,
                Name = FoundOrganisation.Name,
                Address = FoundOrganisation.Address,
                Phone = FoundOrganisation.Phone,
                Email = FoundOrganisation.Email,
                City = FoundOrganisation.City,
                County = FoundOrganisation.County,
                Logo = FoundOrganisation.Logo
            };

            return RetOrg;
        }

        public async Task<IEnumerable<Organisation?>> GetOrganisation()
        {
            return await db.Organisations.ToListAsync();
        }

        //public async Task<organisation?> GetorganisationById(int Id)
        //{
        //    return await db.Organisations.Where(x=> x.Id ==Id).FirstOrDefaultAsync();
        //}

        public async Task AddOrganisation(Organisation organisation)
        {
            if (db.Organisations.Any(x => x.Name.Equals(organisation.Name, StringComparison.OrdinalIgnoreCase))) return;
            db.Organisations.Add(organisation);
            await db.SaveChangesAsync();
        }

        public async Task UpdateOrganisation(Organisation organisation)
        {
            var foundDetails = await db.Organisations.FindAsync((object)organisation.Id);

            //Prevent Duplicate Names

            if (db.Organisations.Any(x => x.Id != organisation.Id && x.Name.ToLower() == organisation.Name.ToLower())) return;

            if (foundDetails != null)
            {
                foundDetails.Name = organisation.Name;
                foundDetails.Address = organisation.Address;
                foundDetails.Phone = organisation.Phone;
                foundDetails.Email = organisation.Email;
                foundDetails.City = organisation.City;
                foundDetails.County = organisation.County;
                foundDetails.Logo = organisation.Logo;

                await db.SaveChangesAsync();
            }

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
