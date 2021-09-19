using DTO.Read;
using DAL.Model.Attributes;
using DAL.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    [CreateDTO(typeof(DifficultyLevelTranslationReadDTO))]
    public class DifficultyLevelTranslation
    {
        public int DifficultyLevelId { get; set; }
        public virtual DifficultyLevel DifficultyLevel { get; set; }
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
        public string Translation { get; set; }
    }
}
