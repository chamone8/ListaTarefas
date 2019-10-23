using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaTarefas.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Tarefas> Tarefas  { get; set; }

        public Contexto(DbContextOptions<Contexto> op) : base(op)
        { }
    }
}
