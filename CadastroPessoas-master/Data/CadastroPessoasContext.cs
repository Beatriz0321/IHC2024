using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CadastroPessoas.Models;

namespace CadastroPessoas.Data
{
    public class CadastroPessoasContext : DbContext
    {
        public CadastroPessoasContext (DbContextOptions<CadastroPessoasContext> options)
            : base(options)
        {
        }

        public DbSet<CadastroPessoas.Models.Cliente> Cliente { get; set; } = default!;
    }
}
