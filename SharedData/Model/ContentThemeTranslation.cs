using DTO.Read;
using DAL.Model.Attributes;

namespace DAL.Model
{
    [CreateDTO(typeof(ContentThemeTranslationReadDTO))]
    public class ContentThemeTranslation
    {
        public int ContentThemeId { get; set; }
        public virtual ContentTheme ContentTheme { get; set; }
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
        public string Translation { get; set; }
    }
}
