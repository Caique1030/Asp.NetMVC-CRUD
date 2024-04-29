using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Asp.NetMVC_CRUD.Models
{
    public class EstudanteContext : DbContext
    {
        public DbSet<Estudante> Estudante { get; set; }
    }
}