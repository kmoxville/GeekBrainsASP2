using PersonsWebApp.DAL.Entities;

namespace PersonsWebApp.DAL.Responses.Person
{
    public class GetPersonsListResponse
    {
        public IReadOnlyList<PersonDto> Persons { get; set; } = default!;
    }
}
