using AutoMapper;
using PersonsWebApp.DAL.Entities;
using PersonsWebApp.DAL.Repository;

namespace PersonsWebApp.Services
{
    public class PersonService : IService<PersonEntity, PersonDto>
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
                await _repository.SaveAsync();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<PersonDto> Get(int id)
        {
            PersonEntity? entity = await _repository.GetByID(id);
            return _mapper.Map<PersonDto>(entity);
        }

        public IEnumerable<PersonDto> GetAll()
        {
            return _repository
                .GetAll()
                .Select(x => _mapper.Map<PersonDto>(x));
        }

        public async Task<PersonDto> InsertAsync(PersonDto item)
        {
            var entity = _mapper.Map<PersonEntity>(item);
            await _repository.InsertAsync(entity);
            await _repository.SaveAsync();

            return _mapper.Map<PersonDto>(entity);
        }

        public async Task Update(PersonDto item)
        {
            PersonEntity? entity = await _repository.GetByID(item.Id);

            if (entity == null)
                return;

            _repository.Update(_mapper.Map<PersonEntity>(item));
            await _repository.SaveAsync();
        }
    }
}
