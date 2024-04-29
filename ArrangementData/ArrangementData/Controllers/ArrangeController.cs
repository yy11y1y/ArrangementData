using Microsoft.AspNetCore.Mvc;
using SharedLibrary.Models;
using SharedLibrary.ArrangeRepositories;
namespace ArrangementData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArrangeController : ControllerBase
    {
        private readonly IArrangeRepository arrangeRepository;
        public ArrangeController(IArrangeRepository arrangeRepository)
        {
            this.arrangeRepository = arrangeRepository;
        }

        [HttpGet("All-Arranges")]
        public async Task<ActionResult<List<Arrange>>> GetAllArrangeAsync()
        {
            var arranges = await arrangeRepository.GetAllArrangesAsync();
            return Ok(arranges);
        }

        [HttpGet("Single-Arrange/{Id}")]
        public async Task<ActionResult<List<Arrange>>> GetSingleArrangeAsync(int id)
        {
            var arrange = await arrangeRepository.GetArrangeByIdAsync(id);
            return Ok(arrange);
        }

        [HttpPost("Add-Arrange")]
        public async Task<ActionResult<List<Arrange>>> AddArrangeAsync(Arrange model)
        {
            var arrange = await arrangeRepository.AddArrangeAsync(model);
            return Ok(arrange);
        }

        [HttpPut("Update-Arrange")]
        public async Task<ActionResult<List<Arrange>>> UpdateArrangeAsync(Arrange model)
        {
            var arrange = await arrangeRepository.UpdateArrangeAsync(model);
            return Ok(arrange);
        }

        [HttpDelete("Delete-Arrange/{Id}")]
        public async Task<ActionResult<List<Arrange>>> DeleteArrangeAsync(int Id)
        {
            var arrange = await arrangeRepository.DeleteArrangeAsync(Id);
            return Ok(arrange);
        }
    }
}
