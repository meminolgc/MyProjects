using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace JWToken.JWT
{
	public class TokenValidator
	{
		public ClaimsPrincipal ValidateJwtToken(string token)
		{
			var tokenHandler = new JwtSecurityTokenHandler();	
			var key = Encoding.UTF8.GetBytes("20Derste20ProjeToken+-*/1234tokenJWT");
			try
			{
				var principal = tokenHandler.ValidateToken(token, new TokenValidationParameters
				{
					ValidateIssuerSigningKey = true,
					IssuerSigningKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(key),
					ValidateIssuer = true,
					ValidIssuer ="localhost",
					ValidateAudience = true,
					ValidAudience = "localhost",
					ValidateLifetime = true,
					ClockSkew = TimeSpan.Zero,
				}, out Microsoft.IdentityModel.Tokens.SecurityToken validatedToken);
				return principal;
			}
			catch (Exception)
			{

				return null;
			}
		}
	}
}
