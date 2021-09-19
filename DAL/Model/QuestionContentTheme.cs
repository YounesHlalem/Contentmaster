using DTO.Read;
using DAL.model.Attributes;
using DAL.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    [ReadDTOAttribute(typeof(QuestionContentThemeReadDTO))]
    public class QuestionContentTheme
    {
        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
        public int ContentThemeId { get; set; }
        public virtual ContentTheme ContentTheme { get; set; }
    }
}
