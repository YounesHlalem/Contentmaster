using System;
using DTO.Read;
using DAL.model.Attributes;
using DAL.Model.Interface;

namespace DAL.Model
{
    [ReadDTOAttribute(typeof(QuestionFormulationTypeTranslationReadDTO))]
    public class QuestionFormulationTypeTranslation
	{
        public int QuestionFormulationTypeId { get; set; }
        public virtual QuestionFormulationType QuestionFormulationType { get; set; }
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
        public string Translation { get; set; }
    }
}