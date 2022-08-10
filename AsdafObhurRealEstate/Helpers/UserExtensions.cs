using AsdafObhurRealEstate.Infrastructure;
using AsdafObhurRealEstate.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security.Claims;

namespace AsdafObhurRealEstate.Helpers
{
    public static class UserExtensions
    {
        private const string preferred_username = "preferred_username";
        private const string departmentIdClaim = "departmentId";

        public static int? GetDepartmentId(this ClaimsPrincipal identity)
        {
            Claim claim = identity?.FindFirst(departmentIdClaim);

            if (claim == null)
                return null;

            return int.Parse(claim.Value);
        }

        public static string GetId(this ClaimsPrincipal identity)
        {
            Claim claim = identity?.Claims.Where(c => c.Type == preferred_username).SingleOrDefault();

            if (claim == null)
                return null;

            return claim.Value;
        }

        public static string GetFullName(this ClaimsPrincipal identity)
        {
            Claim firstClaim = identity?.Claims.Where(c => c.Type == ClaimTypes.GivenName).SingleOrDefault();
            if (firstClaim == null)
                return null;

            Claim secondClaim = identity?.Claims.Where(c => c.Type == ClaimTypes.Surname).SingleOrDefault();
            if (secondClaim == null)
                return null;


            return firstClaim.Value + " " + secondClaim.Value;
        }

        public static string GetFristName(this ClaimsPrincipal identity)
        {
            Claim claim = identity?.Claims.Where(c => c.Type == ClaimTypes.GivenName).SingleOrDefault();

            if (claim == null)
                return null;

            return claim.Value;
        }

        public static string GetFamily(this ClaimsPrincipal identity)
        {
            Claim claim = identity?.Claims.Where(c => c.Type == ClaimTypes.Surname).SingleOrDefault();

            if (claim == null)
                return null;

            return claim.Value;
        }
    }



    public class ApplicationClaimsIdentityFactory : UserClaimsPrincipalFactory<BaseUser>
    {
        UserManager<BaseUser> _userManager;
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
