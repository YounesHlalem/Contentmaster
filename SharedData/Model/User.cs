using DTO.Read;
using DAL.Model.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    [CreateDTO(typeof(UserReadDTO))]
    public class User
    {
        public int Id { get; set; }
        public int PreferredLanguageId { get; set; }
        public virtual Language PreferredLanguage { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
