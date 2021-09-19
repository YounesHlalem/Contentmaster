using BLL.Helpers;
using BLL.Interfaces;
using DAL.Context;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using WebService.Models;
using DAL;

namespace BLL
{
    public class UserService : IUserService
    {
        // users hardcoded for simplicity, store in a db with hashed passwords in production applications
        private List<User> _users { get => _context.Users.ToList(); }
        private E4ProgressContext _context;

        private readonly AppSettings _appSettings;

        public UserService(IOptions<AppSettings> appSettings, E4ProgressContext context)
        {
            _appSettings = appSettings.Value;
            _context = context;
        }

        public AuthenticateResponse Authenticate(AuthenticateRequest model)
        {
            var user = _users.SingleOrDefault(x => x.Email == model.Email);

            // return null if user not found
            if (user == null) return null;

            bool verified = BCrypt.Net.BCrypt.Verify(model.Password, user.Password);
            if (!verified) return null;

            // authentication successful so generate jwt token
            var token = generateJwtToken(user);

            return new AuthenticateResponse(user, token);
        }

        public IEnumerable<User> GetAll()
        {
            return _users;
        }

        public User GetById(int id)
        {
            return _users.FirstOrDefault(x => x.Id == id);
        }

        // helper methods

        private string generateJwtToken(User user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public User Register(RegisterRequest model)
        {
            model.Password = BCrypt.Net.BCrypt.HashPassword(model.Password);
            var user = new User { Firstname = model.Firstname, Lastname = model.Lastname, Email = model.Email, Password = model.Password, PreferredLanguageId = 1 };
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }
    }
}
