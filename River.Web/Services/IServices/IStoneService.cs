using River.Web.Models;

namespace River.Web.Services.IServices
{
    public interface IStoneService
    {
        Task<ResponseDto?> GetAllStonesAsync();
    }
}
