using AutoMapper;
using PersonsWebApp.DAL.Entities;
using PersonsWebApp.DAL.Repository;

namespace PersonsWebApp.Services
{
    public class PersonService : IRepositoryService<PersonEntity, PersonDto>
    {
        private readonly IRepository<PersonEntity> _repository;
        private readonly IMapper _mapper;

        public PersonService(IRepository<PersonEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                await _repository.DeleteAsync(id);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<PersonDto> Get(int id)
        {
            PersonEntity? entity = await _repository.GetByID(id);
            return _mapper.Map<PersonDto>(entity);
        }

        public IQueryable<PersonDto> GetAll()
        {
            return _repository
                .GetAll()
                .Select(x => _mapper.Map<PersonDto>(x));
        }

        public async Task<PersonDto> InsertAsync(PersonDto item)
        {
            var entity = _mapper.Map<PersonEntity>(item);
            await _repository.InsertAsync(entity);

            return _mapper.Map<PersonDto>(entity);
        }

        public async Task Update(PersonDto item)
        {
            PersonEntity? entity = await _repository.GetByID(item.Id);

            if (entity == null)
                return;

            await _repository.Update(_mapper.Map<PersonEntity>(item));
        }
    }
}
