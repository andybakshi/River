using River.Web.Models;
using River.Web.Services.IServices;
using River.Web.Utilities;

namespace River.Web.Services
{
    public class StoneService : IStoneService
    {
        private readonly IBaseService _baseService;

        public StoneService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<ResponseDto?> GetAllStonesAsync()
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.StoneAPIBase + "/api/StoneAPI"
            });
        }
    }
}
