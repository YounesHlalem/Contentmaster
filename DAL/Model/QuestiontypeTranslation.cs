using DTO.Read;
using DAL.model.Attributes;
using DAL.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    [ReadDTOAttribute(typeof(QuestiontypeTranslationReadDTO))]
    public class QuestiontypeTranslation
    {
        public int QuestiontypeId { get; set; }
        public virtual Questiontype Questiontype { get; set; }
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
        public string Translation { get; set; }
    }
}
