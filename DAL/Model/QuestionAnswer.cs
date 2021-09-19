using DTO.Read;
using DAL.model.Attributes;
using DAL.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    [ReadDTOAttribute(typeof(QuestionAnswerReadDTO))]
    public class QuestionAnswer
    {
        public int Id { get; set; }
        public int Questionid { get; set; }
        public virtual Question Question { get; set; }
        public string Answer { get; set; }
        public virtual List<QuizQuestionAnswer> QuestionList { get; set; }
    }
}
