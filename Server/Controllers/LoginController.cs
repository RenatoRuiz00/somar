using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Somar.Server.Services;
using Somar.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Somar.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly LoginService _service;

        public LoginController(LoginService service)
        {
            _service = service;
        }

        [HttpPost("Login")]
        public async Task<ActionResult<Funcionario>> Login([FromBody] Funcionario user)
        {
            Funcionario funcionario = await _service.Login(user);

            if (funcionario!=null)
            {
                return funcionario;
            }
            else
            {
                return BadRequest(new { message = "Login Inválido" });
            }

        }

    }
}
