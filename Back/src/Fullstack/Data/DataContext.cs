using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fullstack.Models;
using Microsoft.EntityFrameworkCore;

namespace Fullstack.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) { }
        public DbSet<Evento> Eventos { get; set; }
    }
}