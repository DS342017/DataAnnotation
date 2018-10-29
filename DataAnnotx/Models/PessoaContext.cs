using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DataAnnotx.Models
{
    public class PessoaContext : DbContext
    {
        public DbSet<Models.Pessoa> Pessoas { get; set; }

       
    }
}