using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class CreateQuizDTO
    {
        public int Id { get; set; }
        public int OfficeApplicationId { get; set; }
        public int InstructionsLanguageId { get; set; }
        public int UserinterfaceLanguageId { get; set; }
        public string Title { get; set; }
        public string ShortIntro { get; set; }
        public string Intro { get; set; }
        public TimeSpan DefaultTimeLimit { get; set; }
        public decimal DefaultMinimumScore { get; set; }
        public string IdentificationCode { get; set; }
        public string Replicationkey { get; set; }
    }
}
