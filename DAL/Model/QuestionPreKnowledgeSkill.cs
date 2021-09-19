using DTO.Read;
using DAL.model.Attributes;
using DAL.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    [ReadDTOAttribute(typeof(QuestionPreKnowledgeSkillReadDTO))]
    public class QuestionPreKnowledgeSkill
    {
        public int Id { get; set; }
        public string Skill { get; set; }
        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
        public int SortOrder { get; set; }
    }
}
