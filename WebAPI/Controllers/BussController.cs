using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BussController : ControllerBase
    {
        private readonly IBussModelService _bussModelService;

        public BussController(IBussModelService bussModelService)
        {
            _bussModelService = bussModelService;
        }

        [HttpGet]
        public async Task<List<BussModel>> Get()
        {
            return await _bussModelService.GetBuss();
        }

        [HttpGet("{colorName}")]
        public async Task<ActionResult<List<BussModel>>> Get(string colorName)
        {
            List<BussModel> bussList = await _bussModelService.GetBussByColor(colorName);
            if (bussList.Count == 0) return NotFound();
            return bussList;
        }
    }
}
