using System;
using Microsoft.EntityFrameworkCore;

using Genesis.Domain.model;
using Genesis.Infrastructure.Data;
using Genesis.Infrastructure.EntityConfig;



namespace TestConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            //    var optionsBuilder = new DbContextOptionsBuilder<GenesisContext>();
            //optionsBuilder.UseSqlServer("Data Source =.\\sqlexpress; Initial Catalog = Genesis; Integrated Security = True; MultipleActiveResultSets = True");
            var optionsBuilder = new DbContextOptionsBuilder<GenesisContext>();
            optionsBuilder.UseSqlServer("Server=tcp:genesissqlserver.database.windows.net,1433;Initial Catalog=genesis;Persist Security Info=False;User ID={genesisadmin};Password={Shafiro1};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");


            var dbc = new GenesisContext(optionsBuilder.Options);
            //AppData.InitCompanyData(dbc);
            HallsInfo.Init(dbc);
            Console.WriteLine("Hello World!");
        }
    }
}
