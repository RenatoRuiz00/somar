using Somar.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Somar.Server.Services
{
    interface ICidade
    {
        public Task<List<Cidade>> Buscar();
    }
}
