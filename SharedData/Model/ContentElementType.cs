using DTO.Read;
using DAL.Model.Attributes;

namespace DAL.Model
{
    [CreateDTO(typeof(ContentElementTypeReadDTO))]
    public class ContentElementType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
