using Microsoft.EntityFrameworkCore;
using Entities;

namespace Infrastructure.Configuration
{ 
    public class ContextBase : DbContext
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
        }
        public DbSet<Empresa> Empresas{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetStringConectionConfig());
                base.OnConfiguring(optionsBuilder);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Empresa>().ToTable("Empresa").HasKey(t => t.Id);

            base.OnModelCreating(builder);
        }


        private string GetStringConectionConfig()
        {
            string strCon = "Data Source=anfsusax;Initial Catalog=MVCTeste;Integrated Security=True";
            // string strCon = "Server=RI-DEV-03\SQLEXPRESS;Database=MVCTeste;User Id=candidato;Password=Teste123;" providerName="System.Data.SqlClient"/>";
            return strCon;
        }
    }
}
