using DTO.Read;
using DAL.Model.Attributes;
using DAL.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    [CreateDTO(typeof(QuizQuestionReadDTO))]
    public class QuizQuestion
    {
        public int QuizId { get; set; }
        public virtual Quiz Quiz { get; set; }
        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
        public int Sortorder { get; set; }
    }
}
