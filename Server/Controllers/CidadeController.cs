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
    public class CidadeController : ControllerBase
    {
        private readonly CidadeService _service;

        public CidadeController(CidadeService service)
        {
            _service = service;
        }

        [HttpGet("getCidades")]
        public async Task<ActionResult<List<Cidade>>> GetCidades()
        {
            try
            {
                List<Cidade> cidades = await _service.Buscar();

                if (cidades != null)
                {
                    return cidades;
                }
                else
                {
                    return BadRequest(new { message = "Não foi possível retornar as cidades" });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Erro: " + ex.Message });
            }

        }

    }
}
