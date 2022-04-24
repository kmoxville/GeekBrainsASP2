using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonsWebApp.DAL.Entities
{
    [Owned]
    [Table("RefreshTokens")]
    public class RefreshTokenEntity : BaseEntity
    {
        public string Token { get; set; } = default!;
    }
}
