using PersonsWebApp.DAL.Entities;

namespace PersonsWebApp.Requests
{
    public class InsertPersonRequest
    {
        public PersonDto Person { get; set; } = default!;
    }
}
