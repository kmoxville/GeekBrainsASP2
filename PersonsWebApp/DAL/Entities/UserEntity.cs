namespace PersonsWebApp.DAL.Entities
{
    public class UserEntity : BaseEntity
    {
        public string Username { get; set; } = default!;
        public string Password { get; set; } = default!;
        public string Role { get; set; } = default!;

        public List<RefreshTokenEntity> RefreshTokens { get; set; } = default!;
    }
}
