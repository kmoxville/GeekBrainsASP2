using System.ComponentModel.DataAnnotations.Schema;

namespace PersonsWebApp.DAL.Entities
{
    public class PersonEntity : BaseEntity
    {
        public string FirstName { get; set; } = default!;

        public string LastName { get; set; } = default!;

        public string Email { get; set; } = default!;

        public string Company { get; set; } = default!;

        public DateTime BirthdayDate { get; set; } = default!;

        [NotMapped]
        public int Age
        {
            get => (DateTime.UtcNow - BirthdayDate).Days / 365;
            set
            {
                BirthdayDate = DateTime.UtcNow.AddYears(-value);
            }
        }
    }
}
