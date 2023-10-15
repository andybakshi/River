using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using River.Services.StoneAPI.Models;
using River.Services.StoneAPI.Models.Dto;

namespace River.Services.StoneAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoneAPIController : ControllerBase
    {
        private readonly ResponseDto _response;
        private readonly IMapper _mapper;

        public StoneAPIController(IMapper mapper) 
        {
            _mapper = mapper;
            _response = new ResponseDto();
        }

        [HttpGet]
        public ResponseDto Get()
        {
            try
            {
                List<Stone> stones = new()
                { 
                    new Stone() {
                        ID = 1,
                        Name = "Red",
                        Description = "Big Red Stone"
                    },                    
                    new Stone() {
                        ID = 1,
                        Name = "Blue",
                        Description = "Big Blue Stone"
                    },
                };

                _response.Result = _mapper.Map<List<StoneDto>>(stones);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }
    }
}
