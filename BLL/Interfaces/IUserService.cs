using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;
using WebService.Models;

namespace BLL.Interfaces
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        IEnumerable<User> GetAll();
        User GetById(int id);
        User Register(RegisterRequest model);
    }
}
