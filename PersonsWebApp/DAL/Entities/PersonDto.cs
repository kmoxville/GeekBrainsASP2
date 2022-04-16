namespace PersonsWebApp.DAL.Entities
{
    public class PersonDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = default!;

        public string LastName { get; set; } = default!;

        public string Email { get; set; } = default!;

        public string Company { get; set; } = default!;

        public int Age { get; set; }
    }
}
