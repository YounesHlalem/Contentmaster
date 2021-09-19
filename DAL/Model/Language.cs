using System;
using DTO.Read;
using DAL.model.Attributes;
using DAL.Model.Interface;

namespace DAL.Model
{
    [ReadDTOAttribute(typeof(LanguageReadDTO))]
    public class Language : IIsDeleted
	{
        public int Id { get; set; }
        public string NativeName { get; set; }
        public string Code { get; set; }
    }
}