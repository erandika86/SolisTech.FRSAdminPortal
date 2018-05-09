using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolisTech.FRSAdminPortal.Data.DbContexts
{
    public class ClientContext:IDisposable
    {
        public imfinzidevEntities Db { get; set; }

        public ClientContext(string connectionString)
        {
            CreatedDbContext(connectionString);
        }

        private void CreatedDbContext(string connectionString)
        {
            var sqlBuilder = new SqlConnectionStringBuilder();
            sqlBuilder.DataSource = @"DESKTOP-6AENO53\SQLEXPRESS";
            sqlBuilder.InitialCatalog = "imfinzidev";
            sqlBuilder.Password = "1qaz2wsx@";
            sqlBuilder.UserID = "sa";
            sqlBuilder.MultipleActiveResultSets = true;
            sqlBuilder.PersistSecurityInfo = true;

            string providerString = sqlBuilder.ToString();

            var entityBuilder = new EntityConnectionStringBuilder();
            // use your ADO.NET connection string
            entityBuilder.ProviderConnectionString = providerString;
            entityBuilder.Provider = "System.Data.SqlClient";


          
            // Set the Metadata location.
            // entityBuilder.Metadata = @"res://*/Model.csdl|res://*/Model.ssdl|res://*/Model.msl";
            entityBuilder.Metadata = @"res://*/DbContexts.ClientDbContext.csdl|res://*/DbContexts.ClientDbContext.ssdl|res://*/DbContexts.ClientDbContext.msl";
            Db = new imfinzidevEntities(entityBuilder.ToString());
            
            
        }

        public void Dispose()
        {
            if (Db != null)
            {
                Db.Dispose();
                Db = null;
            }
        }
    }
}
