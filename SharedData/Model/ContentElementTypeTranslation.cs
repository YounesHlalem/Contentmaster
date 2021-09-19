using DTO.Read;
using DAL.Model.Attributes;
using DAL.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    [CreateDTO(typeof(ContentElementTypeTranslationReadDTO))]
    public class ContentElementTypeTranslation
    {
        public int ContentElementTypeId { get; set; }
        public virtual ContentElementType ContentElementType { get; set; }
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
        public string Translation { get; set; }
    }
}
