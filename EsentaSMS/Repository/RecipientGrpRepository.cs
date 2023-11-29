
using EsentaSMS.Data;
using EsentaSMS.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EsentaSMS.Repository
{
    public class RecipientGrpRepository : IRecipientGrpRepository
    {
        private readonly EsentaSMSContext db;

        public RecipientGrpRepository(EsentaSMSContext SMSContext)
        {
            db = SMSContext;
        }

        public async Task<RecipientGrp?> GetRecipientGrpById(int Id)
        {
            var FoundRecipientGrp = await db.RecipientGrps.FindAsync(Id);
            if (FoundRecipientGrp == null) return FoundRecipientGrp;

            RecipientGrp RetGroup = new()
            {
                Id = FoundRecipientGrp.Id,
                GroupName = FoundRecipientGrp.GroupName
            };

            return RetGroup;
        }

        public async Task<IEnumerable<RecipientGrp?>> GetRecipientGrp()
        {
            return await db.RecipientGrps.ToListAsync();
        }

        //public async Task<RecipientGrp?> GetRecipientGrpById(int Id)
        //{
        //    return await db.RecipientGrp.Where(x=> x.Id ==Id).FirstOrDefaultAsync();
        //}

        public async Task AddRecipientGrp(RecipientGrp RecipientGrp)
        {
            if (db.RecipientGrps.Any(x => x.GroupName.Equals(RecipientGrp.GroupName, StringComparison.OrdinalIgnoreCase))) return;
            db.RecipientGrps.Add(RecipientGrp);
            await db.SaveChangesAsync();
        }

        public async Task UpdateRecipientGrp(RecipientGrp RecipientGrp)
        {
            var foundDetails = await db.RecipientGrps.FindAsync((object)RecipientGrp.Id);

            //Prevent Duplicate Names

            if (db.RecipientGrps.Any(x => x.Id != RecipientGrp.Id && x.GroupName.ToLower() == RecipientGrp.GroupName.ToLower())) return;

            if (foundDetails != null)
            {
                foundDetails.GroupName = RecipientGrp.GroupName;
                await db.SaveChangesAsync();
            }

        }


        public async Task DeleteRecipientGrp(int Id)
        {
            var foundDetails = await db.RecipientGrps.FindAsync(Id);
            if (foundDetails != null)
            {
                db.Remove(foundDetails);
                await db.SaveChangesAsync();
            }
        }
    }
}
