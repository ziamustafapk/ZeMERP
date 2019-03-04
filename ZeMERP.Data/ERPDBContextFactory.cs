using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ZeMERP.Data
{
    public class ERPDBContextFactory : IDesignTimeDbContextFactory<ZeMERPDbContext>
    {
        public ZeMERPDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ZeMERPDbContext>();
            builder.UseSqlServer(GetConnectionString(),
                optionsBuilder => optionsBuilder.MigrationsAssembly(typeof(ZeMERPDbContext).GetTypeInfo().Assembly.GetName().Name));
            return new ZeMERPDbContext(builder.Options);
        }
        

        private static string GetConnectionString()
        {

            return "server=development;database=ZEMERPSample;Integrated Security=SSPI";
            //return "Data Source=app.ybs.cloud;Initial Catalog=ERP;User ID=sa;Password=?9utZPNCP3;Connection Timeout=300 ";


        }


    }

}
