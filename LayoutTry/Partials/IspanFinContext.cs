using Microsoft.EntityFrameworkCore;
namespace LayoutTry.Models { 



    public partial class IspanFinContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfiguration Config = new ConfigurationBuilder()
                                   .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                                   .AddJsonFile("appsettings.json")
                                   .Build();
                optionsBuilder.UseSqlServer(Config.GetConnectionString("ISpanFin"));
            }

            

        }

}
}
