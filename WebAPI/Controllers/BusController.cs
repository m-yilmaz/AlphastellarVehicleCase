using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        private readonly IBusModelService _bussModelService;

        public BusController(IBusModelService bussModelService)
        {
            _bussModelService = bussModelService;
        }

        // GET: api/bus
        [HttpGet]
        public async Task<List<BusModel>> Get()
        {
            return await _bussModelService.GetBus();
        }

        //GET: api/bus/white
        [HttpGet("{colorName}")]
        public async Task<ActionResult<List<BusModel>>> Get(string colorName)
        {
            List<BusModel> bussList = await _bussModelService.GetBusByColor(colorName);
            if (bussList == null ||bussList.Count == 0) return NotFound();
            return bussList;
            
        }
    }
}
