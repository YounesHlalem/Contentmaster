using DTO.Read;
using DAL.Model.Attributes;
using DAL.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    [CreateDTO(typeof(RoleTranslationReadDTO))]
    public class RoleTranslation
    {
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        public int LanguageId { get; set; }
        public virtual Language Languages { get; set; }
        public string Translation { get; set; }
    }
}
