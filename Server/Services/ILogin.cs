using Somar.Shared.Models;
using System.Threading.Tasks;

namespace Somar.Server.Services
{
    interface ILogin
    {
        public Task<Funcionario> Login(Funcionario funcionario);
    }
}
