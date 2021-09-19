using DTO.Read;
using DAL.Model.Attributes;
using DAL.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    [CreateDTO(typeof(QuizReadDTO))]
    public class Quiz
    {
        public int Id { get; set; }
        public int OfficeApplicationId { get; set; }
        public virtual OfficeApplication OfficeApplications { get; set; }
        public int InstructionsLanguageId { get; set; }
        public virtual Language InstructionsLanguage { get; set; }
        public int UserinterfaceLanguageId { get; set; }
        public virtual Language UserinterfaceLanguage { get; set; }
        public string Title { get; set; }
        public string ShortIntro { get; set; }
        public string Intro { get; set; }
        public TimeSpan DefaultTimeLimit { get; set; }
        public decimal DefaultMinimumScore { get; set; }
        public string IdentificationCode { get; set; }
        public string Replicationkey { get; set; }
    }
}
