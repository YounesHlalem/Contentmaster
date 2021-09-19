using DTO.Read;
using DAL.Model.Attributes;
using DAL.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    [CreateDTO(typeof(QuestionPreKnowledgeSkillReadDTO))]
    public class QuestionPreKnowledgeSkill
    {
        public int Id { get; set; }
        public string Skill { get; set; }
        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
        public int SortOrder { get; set; }
    }
}
