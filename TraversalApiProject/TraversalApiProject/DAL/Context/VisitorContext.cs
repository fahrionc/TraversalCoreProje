using Microsoft.EntityFrameworkCore;
using TraversalApiProject.DAL.Entities;

namespace TraversalApiProject.DAL.Context
{
    public class VisitorContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-TICO66R\\MSSQLSERVER01;initial catalog=TraversalDBApi;integrated security=true; TrustServerCertificate=True");
        }
        public DbSet<Visitor> Visitors { get; set; }
    }
}
