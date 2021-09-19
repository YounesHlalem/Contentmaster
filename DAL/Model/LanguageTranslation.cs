using DTO.Read;
using DAL.model.Attributes;
using DAL.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    [ReadDTO(typeof(LanguageTranslationReadDTO))]
    public class LanguageTranslation
    {
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
        public int TranslationLanguageId { get; set; }
        public virtual Language TranslationLanguage { get; set; }
        public string Translation { get; set; }
    }
}
