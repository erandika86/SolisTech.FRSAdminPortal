using SolisTech.FRSAdminPortal.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolisTech.FRSAdminPortal.Business
{
    public interface IMasterDbService:IDisposable
    {
        CompanyViewModel GetCompanyDetails(string tenantId);
    }
}
