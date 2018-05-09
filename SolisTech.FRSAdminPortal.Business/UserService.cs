using SolisTech.FRSAdminPortal.Common;
using SolisTech.FRSAdminPortal.Data.DbContexts;
using SolisTech.FRSAdminPortal.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolisTech.FRSAdminPortal.Business
{
    public class UserService: IUserService
    {
        private ClientContext context;

        public UserService(string connectionString)
        {
            context = new ClientContext(connectionString);
        }


        public UserViewModel AuthernticateUser(string userName,string password)
        {
            try
            {
                var passwordHash = PasswordHasher.GenerateHash(password);
                var user = context.Db.users.FirstOrDefault(t => t.active == 1 && t.mobilenumber == userName && t.userlevel == 5);
                if (user == null)
                {
                    return null;
                }
                else
                {
                    if (user.password == passwordHash)
                    {
                        var userVm = new UserViewModel()
                        {
                            Email = user.email,
                            Id = user.id,
                            MobileNumber = user.mobilenumber,
                            UserName = user.username,
                            UserLevel = user.userlevel
                        };

                        return userVm;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch(Exception ex)
            {
                return null;
            }
        }


        public void Dispose()
        {
            if(context!=null)
            {
                context.Dispose();
                context = null;
            }
        }
    }
}
