using System;

namespace DTO.Read
{
    public class QuizReadDTO
    {
        public int Id { get; set; }
        public int OfficeApplicationId { get; set; }
        public virtual OfficeApplicationReadDTO OfficeApplications { get; set; }
        public int InstructionsLanguageId { get; set; }
        public virtual LanguageReadDTO InstructionsLanguage { get; set; }
        public int UserinterfaceLanguageId { get; set; }
        public virtual LanguageReadDTO UserinterfaceLanguage { get; set; }
        public string Title { get; set; }
        public string ShortIntro { get; set; }
        public string Intro { get; set; }
        public TimeSpan DefaultTimeLimit { get; set; }
        public decimal DefaultMinimumScore { get; set; }
        public string IdentificationCode { get; set; }
        public string Replicationkey { get; set; }
    }
}
