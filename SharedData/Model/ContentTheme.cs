using DTO.Read;
using DAL.Model.Attributes;

namespace DAL.Model
{
    [CreateDTO(typeof(ContentThemeReadDTO))]
    public class ContentTheme
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
