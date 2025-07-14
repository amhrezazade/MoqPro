using Microsoft.AspNetCore.Mvc;

namespace MoqProServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public string Root()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            return "MOQ PRO version " + fvi.FileVersion;
        }
    }
}
