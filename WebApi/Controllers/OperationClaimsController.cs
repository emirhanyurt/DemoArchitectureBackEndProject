

using Business.Abstarct;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationClaimsController : ControllerBase
    {
        private readonly IOperationClaimsService _operationClaimsService;

        public OperationClaimsController(IOperationClaimsService operationClaimsService)
        {
            _operationClaimsService = operationClaimsService;
        }
        [HttpPost("add")]
        public IActionResult Add(OperationClaims operationClaims)
        {
            _operationClaimsService.Add(operationClaims);
            return Ok("Kayıt İşlemi Başarılı");
        }
    }
}
