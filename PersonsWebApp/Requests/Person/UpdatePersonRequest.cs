using PersonsWebApp.DAL.Entities;

namespace PersonsWebApp.Requests
{
    public class UpdatePersonRequest
    {
        public PersonDto Person { get; set; } = default!;
    }
}
