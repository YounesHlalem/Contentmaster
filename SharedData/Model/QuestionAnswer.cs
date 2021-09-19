using DTO.Read;
using DAL.Model.Attributes;
using DAL.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    [CreateDTO(typeof(QuestionAnswerReadDTO))]
    public class QuestionAnswer
    {
        public int Id { get; set; }
        public int Questionid { get; set; }
        public virtual Question Question { get; set; }
        public string Answer { get; set; }
    }
}
