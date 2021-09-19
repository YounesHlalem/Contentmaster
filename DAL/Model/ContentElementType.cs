using DAL.model.Attributes;
using DTO.Read;

namespace DAL.Model
{
    [ReadDTOAttribute(typeof(ContentElementTypeReadDTO))]
    public class ContentElementType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
