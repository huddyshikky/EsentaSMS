
using EsentaSMS.Data.Models;

namespace EsentaSMS.Repository
{
    public interface IRecipientGrpRepository
    {
        Task<RecipientGrp?> GetRecipientGrpById(int Id);
        Task<IEnumerable<RecipientGrp>?> GetRecipientGrp();
        Task<RecipientGrp?> AddRecipientGrp(RecipientGrp RecipientGrp);
        Task<RecipientGrp?> UpdateRecipientGrp(RecipientGrp UpdatedRecipientGrp);
        Task DeleteRecipientGrp(int Id);
    }
}
