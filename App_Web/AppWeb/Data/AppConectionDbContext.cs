using AppWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace AppWeb.Data;

    public class AppConectionDbContext : DbContext
    {
        public AppConectionDbContext(DbContextOptions<AppConectionDbContext> options) : base(options)
        {

        }

          public  DbSet<Cliente> Clientes {  get; set; }
          public DbSet<Produtos> Produtos { get; set; }
          public DbSet<Pedido> Pedidos { get; set; }



    }


