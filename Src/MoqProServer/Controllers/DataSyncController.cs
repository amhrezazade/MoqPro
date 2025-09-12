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

    


    }
}
