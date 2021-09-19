using DTO.Read;
using DAL.model.Attributes;
using DAL.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    [ReadDTOAttribute(typeof(DifficultyLevelTranslationReadDTO))]
    public class DifficultyLevelTranslation
    {
        public int DifficultyLevelId { get; set; }
        public virtual DifficultyLevel DifficultyLevel { get; set; }
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
        public string Translation { get; set; }
    }
}
