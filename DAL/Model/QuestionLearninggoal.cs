using System;
using DTO.Read;
using DAL.model.Attributes;
using DAL.Model.Interface;

namespace DAL.Model
{
    [ReadDTOAttribute(typeof(QuestionLearninggoalReadDTO))]
    public class QuestionLearninggoal
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
        public int DidacticalModelLevelId { get; set; }
        public virtual DidacticalModelLevel DidacticalModelLevel { get; set; }
        public string Learninggoal { get; set; }
        public bool IsMeasurable { get; set; }
        public string Notes { get; set; }
        public int SortOrder { get; set; }
    }
}