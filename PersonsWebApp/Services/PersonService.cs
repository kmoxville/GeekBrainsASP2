using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PersonsWebApp.DAL.Entities;
using PersonsWebApp.DAL.Repository;
using PersonsWebApp.DAL.Validation;
using PersonsWebApp.DAL.Validation.Requests.Person;
using PersonsWebApp.Requests;

namespace PersonsWebApp.Services
{
    public interface IPersonService
    {
        Task<bool> DeleteAsync(DeletePersonByIdRequest request);
        Task<PersonDto?> GetByIdAsync(GetPersonByIdRequest request);
        Task<PersonDto?> GetByIdAsync(int id);
        Task<PersonDto> InsertAsync(InsertPersonRequest request);
        Task UpdateAsync(UpdatePersonRequest request);
        Task<IReadOnlyList<PersonDto>> GetBySearchTermAsync(GetPersonsListBySearchTermRequest request);
        Task<IReadOnlyList<PersonDto>> GetByFilterAsync(GetPersonsListByFilterRequest request);
    }

    internal sealed class PersonService : IPersonService
    {
        private readonly IRepository<PersonEntity> _repository;
        private readonly IMapper _mapper;
        private readonly IGetPersonsListBySearchTermValidator _getPersonsListBySearchTermValidator;
        private readonly IDeletePersonByIdValidator _deletePersonByIdValidator;
        private readonly IGetPersonByIdValidator _getPersonByIdValidator;
        private readonly IInsertPersonValidator _insertPersonValidator;
        private readonly IUpdatePersonValidator _updatePersonValidator;
        private readonly IGetPersonsListByFilterValidator _getPersonsListByFilterValidator;

        public PersonService(
            IRepository<PersonEntity> repository,
            IMapper mapper,
            IGetPersonsListBySearchTermValidator getPersonsListBySearchTermValidator,
            IDeletePersonByIdValidator deletePersonByIdValidator,
            IGetPersonByIdValidator getPersonByIdValidator,
            IInsertPersonValidator insertPersonValidator, 
            IUpdatePersonValidator updatePersonValidator,
            IGetPersonsListByFilterValidator getPersonsListByFilterValidator)
        {
            _repository = repository;
            _mapper = mapper;
            _getPersonsListBySearchTermValidator = getPersonsListBySearchTermValidator;
            _deletePersonByIdValidator = deletePersonByIdValidator;
            _getPersonByIdValidator = getPersonByIdValidator;
            _insertPersonValidator = insertPersonValidator;
            _updatePersonValidator = updatePersonValidator;
            _getPersonsListByFilterValidator = getPersonsListByFilterValidator;
        }

        public async Task<bool> DeleteAsync(DeletePersonByIdRequest request)
        {
            var operationResult = _deletePersonByIdValidator.ValidateRequest(request);

            if (!operationResult.Succeed)
                throw new ValidationException(operationResult);

            try
            {
                await _repository.DeleteAsync(request.Id);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<IReadOnlyList<PersonDto>> GetByFilterAsync(GetPersonsListByFilterRequest request)
        {
            var operationResult = _getPersonsListByFilterValidator.ValidateRequest(request);

            if (!operationResult.Succeed)
                throw new ValidationException(operationResult);

            return await _repository.GetAll()
                .Skip(request.Skip)
                .Take(request.Take)
                .Select(x => _mapper.Map<PersonDto>(x))
                .ToListAsync();
        }

        public async Task<PersonDto?> GetByIdAsync(GetPersonByIdRequest request)
        {
            var operationResult = _getPersonByIdValidator.ValidateRequest(request);

            if (!operationResult.Succeed)
                throw new ValidationException(operationResult);

            PersonEntity? entity = await _repository.GetByIDAsync(request.Id);

            return _mapper.Map<PersonDto>(entity);
        }

        public async Task<PersonDto?> GetByIdAsync(int id)
        {
            PersonEntity? entity = await _repository.GetByIDAsync(id);

            return _mapper.Map<PersonDto>(entity);
        }

        public async Task<IReadOnlyList<PersonDto>> GetBySearchTermAsync(GetPersonsListBySearchTermRequest request)
        {
            var operationResult = _getPersonsListBySearchTermValidator.ValidateRequest(request);

            if (!operationResult.Succeed)
                throw new ValidationException(operationResult);

            return await _repository.GetAll()
                .Where(x => x.LastName.Contains(request.SearchTerm))
                .Select(x => _mapper.Map<PersonDto>(x))
                .ToListAsync();
        }

        public async Task<PersonDto> InsertAsync(InsertPersonRequest request)
        {
            var operationResult = _insertPersonValidator.ValidateRequest(request);

            if (!operationResult.Succeed)
                throw new ValidationException(operationResult);

            var entity = _mapper.Map<PersonEntity>(request.Person);
            await _repository.InsertAsync(entity);

            return _mapper.Map<PersonDto>(entity);
        }

        public async Task UpdateAsync(UpdatePersonRequest request)
        {
            var operationResult = _updatePersonValidator.ValidateRequest(request);

            if (!operationResult.Succeed)
                throw new ValidationException(operationResult);

            PersonEntity? entity = await _repository.GetByIDAsync(request.Person.Id);

            if (entity == null)
                return;

            await _repository.UpdateAsync(_mapper.Map<PersonEntity>(request.Person));
        }
    }
}
