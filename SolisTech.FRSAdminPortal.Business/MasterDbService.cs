using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolisTech.FRSAdminPortal.Data.DbContexts;
using SolisTech.FRSAdminPortal.ViewModel;

namespace SolisTech.FRSAdminPortal.Business
{
    public class MasterDbService : IMasterDbService
    {
        private frsEntities db;

        public MasterDbService()
        {
            db = new frsEntities();
        }

        public void Dispose()
        {
            if (db != null)
            {
                db.Dispose();
                db = null;
            }
        }

        public CompanyViewModel GetCompanyDetails(string tenantId)
        {
            var company = db.companies.FirstOrDefault(t => t.companyid == tenantId);
            if (company == null)
            {
                return null;
            }

            var companyVm = new CompanyViewModel()
            {
                CompanyId = company.companyid,
                Id = company.id,
                CompanyName = company.companyname,
                DatabaseConnectionString = company.dbname
            };

            return companyVm;
        }
    }
}
