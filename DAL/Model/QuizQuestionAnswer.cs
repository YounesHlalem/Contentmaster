using DTO.Read;
using DAL.model.Attributes;
using DAL.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    [ReadDTOAttribute(typeof(QuizQuestionAnswerReadDTO))]
    public class QuizQuestionAnswer
    {
        public int QuizId { get; set; }
        public virtual Quiz Quiz { get; set; }
        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
        public int QuestionAnswerId { get; set; }
        public virtual QuestionAnswer QuestionAnswer { get; set; }
        public decimal Fraction { get; set; }
    }
}
