using AgreementsManagement.Business.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgreementsManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet("{userName}", Name = "GetAccount")]
        public IActionResult GetAccount([FromRoute] string userName)
        {
            try
            {
                return Ok(_accountService.GetAccount(userName));
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
