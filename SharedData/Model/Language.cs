using System;
using DTO.Read;
using DAL.Model.Attributes;
using DAL.Model.Interface;

namespace DAL.Model
{
    [CreateDTO(typeof(LanguageReadDTO))]
    public class Language : IIsDeleted
	{
        public int Id { get; set; }
        public string NativeName { get; set; }
        public string Code { get; set; }
    }
}