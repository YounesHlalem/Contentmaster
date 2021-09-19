using System;
using DTO.Read;
using DAL.Model.Attributes;
using DAL.Model.Interface;

namespace DAL.Model
{
    [CreateDTO(typeof(DidacticalModelLevelTranslationReadDTO))]
    public class DidacticalModelLevelTranslation
	{
        public int DidacticalModelLevelId { get; set; }
        public virtual DidacticalModel DidacticalModelLevel { get; set; }
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
        public string Translation { get; set; }
    }
}