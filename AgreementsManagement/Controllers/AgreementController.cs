using AgreementsManagement.Business.Service;
using AgreementsManagement.DTO.Models.Agreement;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgreementsManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgreementController : ControllerBase
    {
        private readonly IAgreementService _agreementService;

        public AgreementController(IAgreementService agreementService)
        {
            _agreementService = agreementService;
        }
        [HttpGet]
        public IActionResult getAll()
        {
            try
            {
                return Ok(_agreementService.GetAll());
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpGet("{id}", Name = "GetById")]
        public IActionResult GetById([FromRoute] int id)
        {
            try
            {
                return Ok(_agreementService.GetById(id));
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public IActionResult post([FromBody] AgreementCreateDto agreement)
        {
            try
            {
                var data = _agreementService.Post(agreement);
                return Ok(data);
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPut("{id}", Name = "update")]
        public IActionResult update([FromBody] AgreementEditDto newAgreement, [FromRoute] int id)
        {
            try
            {
                var isUpdateSuccessful = _agreementService.Update(newAgreement, id);

                if (isUpdateSuccessful)
                {
                    return Ok();
                }
                else
                {
                    return NoContent();
                } 
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}", Name = "del")]
        public IActionResult del([FromRoute] int id)
        {
            try
            {
                var isDeleteSuccessful = _agreementService.DeleteById(id);

                if (isDeleteSuccessful)
                {
                    return Ok();
                }
                else
                {
                    return NotFound();
                }
             
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpGet("paging")]
        public IActionResult GetPaging([FromQuery] AgreementPagingDto PagedRequest)
        {
            try
            {
                
                return Ok(_agreementService.GetAllPaging(PagedRequest));
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
