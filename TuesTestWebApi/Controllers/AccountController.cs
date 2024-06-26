using Microsoft.AspNetCore.Mvc;
using TuesTestWebApi.Dtos.Account;
using TuesTestWebApi.Dtos.Customer;
using TuesTestWebApi.Dtos.Transaction;
using TuesTestWebApi.Interface;
using TuesTestWebApi.Mappers;
using TuesTestWebApi.Model;

namespace TuesTestWebApi.Controllers
{
    [ApiController]
    [Route("api/account")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository _repository;
        public AccountController(IAccountRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult CreateAccount([FromBody] Guid customerId)
        {
            var account = _repository.CreateAccount(customerId);
            return Ok(account);
        }
    }
}
