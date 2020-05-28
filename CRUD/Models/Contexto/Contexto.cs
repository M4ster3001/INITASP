using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD.Models.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Models.Contexto
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> option) : base(option) {

            Database.EnsureCreated();
        }

        public DbSet<Usuario> Usuario { get; set; }
    }
}
