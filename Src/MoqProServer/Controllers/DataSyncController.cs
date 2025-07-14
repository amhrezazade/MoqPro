using Microsoft.AspNetCore.Mvc;
using MoqProDomain.Entity;
using MoqProDomain.Service;

namespace MoqProServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DataSyncController : ControllerBase
    {

        private readonly DataService _dataService;

        public DataSyncController(DataService dataService)
        {
            _dataService = dataService;
        }

        // ------------------- Request -------------------

        [HttpGet("requests")]
        public ActionResult<List<Request>> GetAllRequests()
        {
            return _dataService.GetAllRequests();
        }

        [HttpGet("requests/{id}")]
        public ActionResult<Request> GetRequestById(Guid id)
        {
            var item = _dataService.GetRequestById(id);
            if (item == null) return NotFound();
            return item;
        }

        [HttpPost("requests")]
        public IActionResult AddRequest([FromBody] Request request)
        {
            request.Id = Guid.NewGuid();
            _dataService.AddRequest(request);
            return CreatedAtAction(nameof(GetRequestById), new { id = request.Id }, request);
        }

        [HttpPut("requests/{id}")]
        public IActionResult UpdateRequest(Guid id, [FromBody] Request request)
        {
            if (id != request.Id) return BadRequest("ID mismatch");
            _dataService.UpdateRequest(request);
            return NoContent();
        }

        [HttpDelete("requests/{id}")]
        public IActionResult DeleteRequest(Guid id)
        {
            _dataService.DeleteRequest(id);
            return NoContent();
        }

        // ------------------- DataType -------------------

        [HttpGet("datatypes")]
        public ActionResult<List<DataType>> GetAllDataTypes()
        {
            return _dataService.GetAllDataTypes();
        }

        [HttpGet("datatypes/{id}")]
        public ActionResult<DataType> GetDataTypeById(Guid id)
        {
            var item = _dataService.GetDataTypeById(id);
            if (item == null) return NotFound();
            return item;
        }

        [HttpPost("datatypes")]
        public IActionResult AddDataType([FromBody] DataType dataType)
        {
            dataType.Id = Guid.NewGuid();
            _dataService.AddDataType(dataType);
            return CreatedAtAction(nameof(GetDataTypeById), new { id = dataType.Id }, dataType);
        }

        [HttpPut("datatypes/{id}")]
        public IActionResult UpdateDataType(Guid id, [FromBody] DataType dataType)
        {
            if (id != dataType.Id) return BadRequest("ID mismatch");
            _dataService.UpdateDataType(dataType);
            return NoContent();
        }

        [HttpDelete("datatypes/{id}")]
        public IActionResult DeleteDataType(Guid id)
        {
            _dataService.DeleteDataType(id);
            return NoContent();
        }


    }
}
