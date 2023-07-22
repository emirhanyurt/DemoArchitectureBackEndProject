using Business.Abstarct;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserOperationController : ControllerBase
    {
        private readonly IUserOperationService _userOperationService;

        public UserOperationController(IUserOperationService userOperationService)
        {
            _userOperationService = userOperationService;
        }

        [HttpPost("add")]
        public IActionResult Add(UserOperationClaims userOperationClaims)
        {
            _userOperationService.Add(userOperationClaims);
            return Ok("Kayıt İşlemi Başarılı");
        }
    }
}
