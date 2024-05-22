using Microsoft.AspNetCore.Mvc;
using SharedLibrary.Models;
using SharedLibrary.ArrangeRepositories;
using static SharedLibrary.Models.Arrange;
using ArrangementData.Implementions;
namespace ArrangementData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArrangeController : ControllerBase
    {
        private readonly ArrangeRepository arrangeRepository;
        public ArrangeController(IArrangeRepository arrangeRepository)
        {
            this.arrangeRepository = (ArrangeRepository?)arrangeRepository;
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

        [HttpGet("All-Arranges/{Bed_Id}/{Date}/{Slot}/{IsReserved}/{Patient_Id}")]
        public async Task<IActionResult> GetArrangementAsync([FromQuery] string Bed_Id, [FromQuery] DateTime Date, [FromQuery] TimeSlot Slot, [FromQuery] bool IsReserved, [FromQuery] string Patient_Id)
        {
            var arranges = await arrangeRepository.GetArrangementAsync(Bed_Id, Date, Slot, IsReserved, Patient_Id);
            if (arranges == null || !arranges.Any())
            {
                return NotFound();
            }
            return Ok(arranges);
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


//[HttpGet("Get-Arrange")]
//public async Task<ActionResult<Arrange>> GetArrangementAsync(string Bed_Id, DateTime Date, TimeSlot Slot, bool IsReserved , string Patient_Id, string Operator)
//{
//    var arrange = await arrangeRepository.GetArrangementAsync(Bed_Id, Date, Slot ,IsReserved , Patient_Id,);
//    if (arrange == null)
//    {
//        return NotFound();
//    }
//    return Ok(arrange);
//}
