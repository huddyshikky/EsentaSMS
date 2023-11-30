using EsentaSMS.Data.Models;

namespace EsentaSMS.Services.Interface
{
    public interface IRecipientGrpService
    {
        Task<RecipientGrp?> AddRecipientGrpAsync(RecipientGrp recipientGrp);
        Task DeleteRecipientGrpAsync(int Id);
        Task<RecipientGrp?> UpdateRecipientGrpAsync(RecipientGrp UpdatedRecipientGrp);
        Task<RecipientGrp?> GetRecipientGrpByIdAsync(int Id);
        Task<IEnumerable<RecipientGrp>?> GetAllRecipientGrpAsync();
    }
}
