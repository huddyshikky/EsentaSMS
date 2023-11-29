using EsentaSMS.Data.Models;

namespace EsentaSMS.Services.Interface
{
    public interface IRecipientGrpService
    {
        Task AddRecipientGrpAsync(RecipientGrp recipientGrp);
        Task DeleteRecipientGrpAsync(int Id);
        Task EditRecipientGrpAsync(RecipientGrp recipientGrp);
        Task<RecipientGrp> GetRecipientGrpByIdAsync(int Id);
        Task<IEnumerable<RecipientGrp>> GetAllRecipientGrpAsync();
    }
}
