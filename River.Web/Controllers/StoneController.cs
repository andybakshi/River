using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using River.Web.Models;
using River.Web.Services.IServices;

namespace River.Web.Controllers
{
    public class StoneController : Controller
    {
        private readonly IStoneService _stoneService;

        public StoneController(IStoneService stoneService)
        {
            _stoneService = stoneService;
        }

        public async Task<IActionResult> Index()
        {
            List<StoneDto>? stones = new();

            ResponseDto? response = await _stoneService.GetAllStonesAsync();

            if (response != null && response.IsSuccess)
            {
                stones = JsonConvert.DeserializeObject<List<StoneDto>>(Convert.ToString(response.Result));
            }

            return View(stones);
        }
    }
}
