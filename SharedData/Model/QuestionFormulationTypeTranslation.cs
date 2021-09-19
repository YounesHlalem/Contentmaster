using System;
using DTO.Read;
using DAL.Model.Attributes;
using DAL.Model.Interface;

namespace DAL.Model
{
    [CreateDTO(typeof(QuestionFormulationTypeTranslationReadDTO))]
    public class QuestionFormulationTypeTranslation
	{
        public int QuestionFormulationTypeId { get; set; }
        public virtual QuestionFormulationType QuestionFormulationType { get; set; }
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
        public string Translation { get; set; }
    }
}