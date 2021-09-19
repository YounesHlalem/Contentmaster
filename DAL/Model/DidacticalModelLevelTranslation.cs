using System;
using DTO.Read;
using DAL.model.Attributes;
using DAL.Model.Interface;

namespace DAL.Model
{
    [ReadDTOAttribute(typeof(DidacticalModelLevelTranslationReadDTO))]
    public class DidacticalModelLevelTranslation
	{
        public int DidacticalModelLevelId { get; set; }
        public virtual DidacticalModel DidacticalModelLevel { get; set; }
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
        public string Translation { get; set; }
    }
}