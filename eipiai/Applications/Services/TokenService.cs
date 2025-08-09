using eipiai.Dominio.Model;
using System.Security.Claims;
using System.Text;


namespace eipiai.Applications.Services
{
    public class TokenService
    {
        public static object GenerateToken(Livros livros, ClaimsIdentity claimsIdentity)
        {
            var Key = Encoding.ASCII.GetBytes(eipiai.Key.Secret);
            var tokenConfig = new SecurityTokenDescriptor
            {
                Subject = claimsIdentity,
                Expires = DateTime.UtcNow.AddHours(3),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Key), SecurityAlgorithms.Aes128CbcHmacSha256)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenConfig);
            var tokenString = tokenHandler.WriteToken(token);

            return new
            {
                token = tokenString
            };
        }
    }
}