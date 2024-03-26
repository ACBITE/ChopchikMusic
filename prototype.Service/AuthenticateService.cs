using System;
using System.Security.Claims;

namespace prototype.Service
{
	public class AuthenticateService
	{
		public static ClaimsIdentity Authenticate(User user)
		{
			var claims = new List<Claim>
			{
				new Claim(ClaimsIdentity.DefaultNameClaimType, user.Name),
				new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role)
			};
            return new(claims, "Token", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
        }
    }
}

