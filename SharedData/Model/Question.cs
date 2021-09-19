using DTO.Read;
using DAL.Model.Attributes;
using DAL.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    [CreateDTO(typeof(QuestionReadDTO))]
    public class Question
    {
        public int Id { get; set; }
        public int QuestionTypeId { get; set; }
        public virtual Questiontype Questiontype { get; set; }
        public bool IsMasterQuestion { get; set; }
        public int MasterQuestionId { get; set; }
        public virtual Question MasterQuestion { get; set; }
        public int InstructionsLanguageId { get; set; }
        public virtual Language InstructionsLanguage { get; set; }
        public int UserinterfaceLanguageId { get; set; }
        public virtual Language UserinterfaceLanguage { get; set; }
        public int QuestionFormulationTypeId { get; set; }
        public virtual QuestionFormulationType QuestionFormulationType { get; set; }
        public int OfficeApplicationId { get; set; }
        public virtual OfficeApplication OfficeApplication { get; set; }
        public string Title { get; set; }
        public string Questiontext { get; set; }
        public string Notes { get; set; }
        public int VersionNumber { get; set; }
        public string Replicationkey { get; set; }
    }
}
