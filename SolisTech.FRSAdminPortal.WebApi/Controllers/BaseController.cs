using SolisTech.FRSAdminPortal.Business;
using SolisTech.FRSAdminPortal.Data.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Http;

namespace SolisTech.FRSAdminPortal.WebApi.Controllers
{
    public class BaseController: ApiController
    {
        public string TenantId { get; set; }

        public BaseController()
        {

        }

        public string GetTenantId()
        {
            ClaimsIdentity claimsIdentity = User.Identity as ClaimsIdentity;
            var claims = claimsIdentity.Claims.Select(x => new { type = x.Type, value = x.Value });
            var tenantClaim = claims.FirstOrDefault(t => t.type == "TenantId");
            return tenantClaim.value;
        }

        public ClientContext GetDbContext()
        {
            try
            {
                string connectionString = string.Empty;
                using (IMasterDbService dbService = new MasterDbService())
                {
                    connectionString = dbService.GetCompanyDetails(GetTenantId()).DatabaseConnectionString;
                }

                var client = new ClientContext(connectionString);

                return client;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}