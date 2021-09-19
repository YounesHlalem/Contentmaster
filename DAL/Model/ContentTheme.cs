using DTO.Read;
using DAL.model.Attributes;

namespace DAL.Model
{
    [ReadDTOAttribute(typeof(ContentThemeReadDTO))]
    public class ContentTheme
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
