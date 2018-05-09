using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using SolisTech.FRSAdminPortal.Business;
using SolisTech.FRSAdminPortal.Common;
using SolisTech.FRSAdminPortal.WebApi.Models;

namespace SolisTech.FRSAdminPortal.WebApi.Providers
{
    public class ApplicationOAuthProvider : OAuthAuthorizationServerProvider
    {
        private readonly string _publicClientId;

        public ApplicationOAuthProvider(string publicClientId)
        {
            if (publicClientId == null)
            {
                throw new ArgumentNullException("publicClientId");
            }

            _publicClientId = publicClientId;
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {

            var form = await context.Request.ReadFormAsync();
            var tenantId = form["tenantId"];
            if(string.IsNullOrEmpty(tenantId))
            {
                context.SetError("invalid_grant", "The tenant name is incorrect.");
                return;
            }
            else
            {
                //get tenant connection string from master database
                IMasterDbService dbService = new MasterDbService();
                var company = dbService.GetCompanyDetails(tenantId);
                dbService.Dispose();

                if (company == null)
                {
                    context.SetError("invalid_grant", "The tenant name is incorrect.");
                    return;
                }
                else
                {

                    //Find the the user using username and password
                    using (IUserService userService = new UserService(company.DatabaseConnectionString))
                    {
                        var loggedInUser = userService.AuthernticateUser(context.UserName, context.Password);
                        if(loggedInUser==null)
                        {
                            context.SetError("invalid_grant", "The user name or password is incorrect.");
                            return;
                        }
                        else
                        {
                            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                            identity.AddClaim(new Claim(ClaimTypes.Email, loggedInUser.Email));
                            identity.AddClaim(new Claim("TenantId", company.CompanyId));
                            var userRoles = new List<string>();
 
                            if(loggedInUser.UserLevel==5)
                            {
                                identity.AddClaim(new Claim(ClaimTypes.Role, UserRole.Administrator.ToString()));
                                userRoles.Add(UserRole.Administrator.ToString());

                            }

                            //If want to extend to other user level then, need to add the role for other user types


                            var principal = new GenericPrincipal(identity, userRoles.ToArray());

                            Thread.CurrentPrincipal = principal;

                            context.Validated(identity);
                        }
                    }


                    //Generate Claim
                }
            }

            //var userManager = context.OwinContext.GetUserManager<ApplicationUserManager>();

            //ApplicationUser user = await userManager.FindAsync(context.UserName, context.Password);

            //if (user == null)
            //{
            //    context.SetError("invalid_grant", "The user name or password is incorrect.");
            //    return;
            //}

            //ClaimsIdentity oAuthIdentity = await user.GenerateUserIdentityAsync(userManager,
            //   OAuthDefaults.AuthenticationType);
            //ClaimsIdentity cookiesIdentity = await user.GenerateUserIdentityAsync(userManager,
            //    CookieAuthenticationDefaults.AuthenticationType);

            //AuthenticationProperties properties = CreateProperties(user.UserName);
            //AuthenticationTicket ticket = new AuthenticationTicket(oAuthIdentity, properties);
            //context.Validated(ticket);
            //context.Request.Context.Authentication.SignIn(cookiesIdentity);
        }

        public override Task TokenEndpoint(OAuthTokenEndpointContext context)
        {
            foreach (KeyValuePair<string, string> property in context.Properties.Dictionary)
            {
                context.AdditionalResponseParameters.Add(property.Key, property.Value);
            }

            return Task.FromResult<object>(null);
        }

        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            // Resource owner password credentials does not provide a client ID.
            if (context.ClientId == null)
            {
                context.Validated();
            }

            return Task.FromResult<object>(null);
        }

        public override Task ValidateClientRedirectUri(OAuthValidateClientRedirectUriContext context)
        {
            if (context.ClientId == _publicClientId)
            {
                Uri expectedRootUri = new Uri(context.Request.Uri, "/");

                if (expectedRootUri.AbsoluteUri == context.RedirectUri)
                {
                    context.Validated();
                }
            }

            return Task.FromResult<object>(null);
        }

        public static AuthenticationProperties CreateProperties(string userName)
        {
            IDictionary<string, string> data = new Dictionary<string, string>
            {
                { "userName", userName }
            };
            return new AuthenticationProperties(data);
        }
    }
}