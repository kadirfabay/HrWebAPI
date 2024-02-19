using HRWebAPI.Models;
using HRWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace HRWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersInformationController : Controller
    {
        private readonly IUsersInformationService _usersInformationService;
        public UsersInformationController(IUsersInformationService usersInformationService)
        {
            _usersInformationService = usersInformationService;
        }
        [HttpPost]
        public async Task<IActionResult> AddUsersInformation([FromBody] UsersInformation usersInformation)
        {
            var result = await _usersInformationService.CreateUsersInformation(usersInformation);

            return Ok(result);
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
