using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoatController : ControllerBase
    {
        private readonly IBoatModelService _boatModelService;

        public BoatController(IBoatModelService boatModelService)
        {
            _boatModelService = boatModelService;
        }
        // GET: api/boat
        [HttpGet]
        public async Task<List<BoatModel>> Get()
        {
            return await _boatModelService.GetBoat();
        }

        // GET: api/boat/red
        [HttpGet("{colorName}")]
        public async Task<ActionResult<List<BoatModel>>> Get(string colorName)
        {
            List<BoatModel> boatList = await _boatModelService.GetBoatByColor(colorName);
            if (boatList == null || boatList.Count == 0) return NotFound();
            return boatList;

        }
    }
}
