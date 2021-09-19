namespace DTO.Read
{
    public class UserReadDTO
    {
        public int Id { get; set; }
        public int PreferredLanguageId { get; set; }
        public virtual LanguageReadDTO PreferredLanguage { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
