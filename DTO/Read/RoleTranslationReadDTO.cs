namespace DTO.Read
{
    public class RoleTranslationReadDTO
    {
        public int RoleId { get; set; }
        public virtual RoleReadDTO Role { get; set; }
        public int LanguageId { get; set; }
        public virtual LanguageReadDTO Languages { get; set; }
        public string Translation { get; set; }
    }
}
