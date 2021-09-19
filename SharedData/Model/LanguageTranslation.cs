using DTO.Read;
using DAL.Model.Attributes;
using DAL.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    [CreateDTO(typeof(LanguageTranslationReadDTO))]
    public class LanguageTranslation
    {
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
        public int TranslationLanguageId { get; set; }
        public virtual Language TranslationLanguage { get; set; }
        public string Translation { get; set; }
    }
}
