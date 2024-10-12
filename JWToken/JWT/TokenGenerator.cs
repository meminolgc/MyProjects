using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Claims;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.IdentityModel.JsonWebTokens;

namespace JWToken.JWT
{
	public class TokenGenerator
	{
		public string GenerateJwtToken(string username, string email, string name, string surname)
		{
			var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("20Derste20ProjeToken+-*/1234tokenJWT"));
			var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
			var claimsExample = new[]
			{
				new System.Security.Claims.Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Sub, username),
				new System.Security.Claims.Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Email, email),
				new System.Security.Claims.Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.GivenName, name),
				new System.Security.Claims.Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.FamilyName, surname),
				new System.Security.Claims.Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
			};

			var token = new JwtSecurityToken(
				issuer: "localhost",
				audience: "localhost",
				claims: claimsExample,
				expires: DateTime.Now.AddMinutes(5),
				signingCredentials: credentials
				);

			return new JwtSecurityTokenHandler().WriteToken(token);
		}

		public string GenerateJwtToken2(string username)
		{
			var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("20Derste20ProjeToken+-*/1234tokenJWT"));
			var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
			var claimsExample = new[]
			{
				new System.Security.Claims.Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Sub, username),
				new System.Security.Claims.Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
			};

			var token = new JwtSecurityToken(
				issuer: "localhost",
				audience: "localhost",
				claims: claimsExample,
				expires: DateTime.Now.AddMinutes(5),
				signingCredentials: credentials
				);

			return new JwtSecurityTokenHandler().WriteToken(token);
		}
	}
}
