
using EsentaSMS.Data;
using EsentaSMS.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EsentaSMS.Repository
{
    public class RecipientGrpRepository(EsentaSMSContext SMSContext) : IRecipientGrpRepository
    {
        private readonly EsentaSMSContext db = SMSContext;

        public async Task<RecipientGrp?> GetRecipientGrpById(int Id)
        {
            return await db.RecipientGrps.FindAsync(Id);  
        }

        public async Task<IEnumerable<RecipientGrp?>> GetRecipientGrp()
        {
            return await db.RecipientGrps.ToListAsync();
        }

        public async Task<RecipientGrp?> AddRecipientGrp(RecipientGrp RecipientGrp)
        {
            if (db.RecipientGrps.Any(x => x.GroupName.ToLower().Equals(RecipientGrp.GroupName.ToLower()))) return null;
            
            db.RecipientGrps.Add(RecipientGrp);
            await db.SaveChangesAsync();
            return RecipientGrp;
        }

        public async Task<RecipientGrp?> UpdateRecipientGrp(RecipientGrp UpdatedRecipientGrp)
        {
            var existingRecipientGrp = await db.RecipientGrps.FindAsync(UpdatedRecipientGrp.Id);

            if (existingRecipientGrp != null)
            {
                existingRecipientGrp.GroupName = UpdatedRecipientGrp.GroupName;
                
                await db.SaveChangesAsync();
                return existingRecipientGrp;
            }

            return null;
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
