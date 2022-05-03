using PersonsWebApp.DAL.Entities;

namespace PersonsWebApp.DAL.Responses.Person
{
    public class GetPersonResponse
    {
        public PersonDto Person { get; set; } = null!;
    }
}
