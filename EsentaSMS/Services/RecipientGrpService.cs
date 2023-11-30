using EsentaSMS.Data.Models;
using EsentaSMS.Repository;
using EsentaSMS.Services.Interface;

namespace EsentaSMS.Services
{
    public class RecipientGrpService(IRecipientGrpRepository _RecipientGrpRepository) : IRecipientGrpService
    {
        private readonly IRecipientGrpRepository RecipientGrpRepository = _RecipientGrpRepository;

        public async Task<RecipientGrp?> AddRecipientGrpAsync(RecipientGrp recipientGrp)
        {
            return await RecipientGrpRepository.AddRecipientGrp(recipientGrp);
        }

        public async Task DeleteRecipientGrpAsync(int Id)
        {
            await RecipientGrpRepository.DeleteRecipientGrp(Id);
        }

        public async Task<RecipientGrp?> UpdateRecipientGrpAsync(RecipientGrp UpdatedRecipientGrp)
        {
            return await RecipientGrpRepository.UpdateRecipientGrp(UpdatedRecipientGrp);
        }

        public async Task<IEnumerable<RecipientGrp>> GetAllRecipientGrpAsync()
        {
            return await RecipientGrpRepository.GetRecipientGrp();
        }

        public async Task<RecipientGrp> GetRecipientGrpByIdAsync(int Id)
        {
            return await RecipientGrpRepository.GetRecipientGrpById(Id);
        }
    }
}
