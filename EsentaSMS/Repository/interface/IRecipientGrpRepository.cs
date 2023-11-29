
using EsentaSMS.Data.Models;

namespace EsentaSMS.Repository
{
    public interface IRecipientGrpRepository
    {
        Task<RecipientGrp?> GetRecipientGrpById(int Id);
        Task<IEnumerable<RecipientGrp?>> GetRecipientGrp();
        Task AddRecipientGrp(RecipientGrp RecipientGrp);
        Task UpdateRecipientGrp(RecipientGrp RecipientGrp);
        Task DeleteRecipientGrp(int Id);
    }
}
