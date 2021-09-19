using DAL.model.Attributes;
using DTO.Read;

namespace DAL.Model
{
    [ReadDTOAttribute(typeof(ContentElementTypeTranslationReadDTO))]
    public class ContentElementTypeTranslation
    {
        public int ContentElementTypeId { get; set; }
        public virtual ContentElementType ContentElementType { get; set; }
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
        public string Translation { get; set; }
    }
}
