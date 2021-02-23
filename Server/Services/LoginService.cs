using Microsoft.EntityFrameworkCore;
using Somar.Server.Data;
using Somar.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Somar.Server.Services
{
    public class LoginService : ILogin
    {
        private readonly AppDbContext _context;

        public LoginService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Funcionario> Login(Funcionario funcionario)
        {
            Funcionario usuario = await _context.Funcionarios
                 .Where(x => x.Usuario == funcionario.Usuario && x.Senha == funcionario.Senha)
                 .FirstOrDefaultAsync();

            return usuario;
        }

    }
}
