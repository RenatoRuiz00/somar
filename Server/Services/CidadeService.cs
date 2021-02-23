using Microsoft.EntityFrameworkCore;
using Somar.Server.Data;
using Somar.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Somar.Server.Services
{
    public class CidadeService : ICidade
    {
        private readonly AppDbContext _context;

        public CidadeService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Cidade>> Buscar()
        {
            return await _context.Cidades.ToListAsync();
        }
    }
}
