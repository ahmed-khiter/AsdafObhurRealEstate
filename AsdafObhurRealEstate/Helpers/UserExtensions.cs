using AsdafObhurRealEstate.Infrastructure;
using AsdafObhurRealEstate.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Reflection;
using System.Security.Claims;

namespace AsdafObhurRealEstate.Helpers
{
    public static class UserExtensions
    {
        /// <summary>
        ///     A generic extension method that aids in reflecting 
        ///     and retrieving any attribute that is applied to an `Enum`.
        /// </summary>
        public static TAttribute GetAttribute<TAttribute>(this Enum enumValue)
                where TAttribute : Attribute
        {
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<TAttribute>();
        }
    }



    public class ApplicationClaimsIdentityFactory : UserClaimsPrincipalFactory<BaseUser>
    {
        public ApplicationClaimsIdentityFactory(UserManager<BaseUser> userManager,
            IOptions<IdentityOptions> optionsAccessor) : base(userManager, optionsAccessor)
        { }
        public async override Task<ClaimsPrincipal> CreateAsync(BaseUser user)
        {
            var principal = await base.CreateAsync(user);
            ((ClaimsIdentity)principal.Identity).AddClaims(new[]
            {
                new Claim("fullName",$"{user.FirstName} {user.LastName}"),
            });
        
            return principal;
        }


    }
}
