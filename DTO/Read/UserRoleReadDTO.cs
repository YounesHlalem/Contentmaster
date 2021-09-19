namespace DTO.Read
{
    public class UserRoleReadDTO
    {
        public int UserId { get; set; }
        public virtual UserReadDTO User { get; set; }
        public int RoleId { get; set; }
        public virtual RoleReadDTO Role { get; set; }
    }
}
