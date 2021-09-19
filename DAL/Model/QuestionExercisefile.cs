using DTO.Read;
using DAL.model.Attributes;
using DAL.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    [ReadDTOAttribute(typeof(QuestionExercisefileReadDTO))]
    public class QuestionExercisefile
    {
        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
        public int ExercisefileId { get; set; }
        public virtual Exercisefile Exercisefile { get; set; }
    }
}
