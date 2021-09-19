using System;
using DTO.Read;
using DAL.Model.Attributes;
using DAL.Model.Interface;

namespace DAL.Model
{
    [CreateDTO(typeof(DidacticalModelTranslationReadDTO))]
    public class DidacticalModelTranslation
    {
        public int DidacticalModelId { get; set; }
        public virtual DidacticalModel DidacticalModel { get; set; }
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
        public string Translation { get; set; }
    }
}
