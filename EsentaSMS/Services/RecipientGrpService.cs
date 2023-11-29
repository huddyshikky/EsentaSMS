using EsentaSMS.Data.Models;
using EsentaSMS.Repository;
using EsentaSMS.Services.Interface;

namespace EsentaSMS.Services
{
    public class RecipientGrpService: IRecipientGrpService
    {
        private readonly IRecipientGrpRepository RecipientGrpRepository;

        public RecipientGrpService(IRecipientGrpRepository _RecipientGrpRepository)
        {
            RecipientGrpRepository = _RecipientGrpRepository;
        }


        public async Task AddRecipientGrpAsync(RecipientGrp recipientGrp)
        {
            await RecipientGrpRepository.AddRecipientGrp(recipientGrp);
        }

        public async Task DeleteRecipientGrpAsync(int Id)
        {
            await RecipientGrpRepository.DeleteRecipientGrp(Id);
        }

        public async Task EditRecipientGrpAsync(RecipientGrp recipientGrp)
        {
            await RecipientGrpRepository.UpdateRecipientGrp(recipientGrp);
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
