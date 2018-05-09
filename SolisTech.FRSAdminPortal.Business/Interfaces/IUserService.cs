using SolisTech.FRSAdminPortal.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolisTech.FRSAdminPortal.Business
{
    public interface IUserService:IDisposable
    {
        UserViewModel AuthernticateUser(string userName, string password);
    }
}
