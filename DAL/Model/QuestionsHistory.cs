using DTO.Read;
using DAL.model.Attributes;
using DAL.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    [ReadDTOAttribute(typeof(QuestionsHistoryReadDTO))]
    public class QuestionsHistory
    {
        public string QuestionReplicationkey { get; set; }
        public char Action { get; set; }
        public DateTime ActionTimestamp { get; set; }
        public int ActionDoneByUserId { get; set; }
        public virtual User ActionDoneByUser { get; set; }
        public int QuestionTypeId { get; set; }
        public bool IsMasterQuestion { get; set; }
        public int MasterQuestionId { get; set; }
        public int InstructionsLanguageId { get; set; }
        public int UserinterfaceLanguageId { get; set; }
        public int QuestionFormulationTypeId { get; set; }
        public int OfficeApplicationId { get; set; }
        public string title { get; set; }
        public string Questiontext { get; set; }
        public string Notes { get; set; }
        public int VersionNumber { get; set; }
    }
}
