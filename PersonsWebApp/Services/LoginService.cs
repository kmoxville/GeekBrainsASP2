using AutoMapper;
using Microsoft.IdentityModel.Tokens;
using PersonsWebApp.DAL.Entities;
using PersonsWebApp.DAL.Repository;
using PersonsWebApp.Utils;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace PersonsWebApp.Services
{
    public class LoginService : ILoginService
    {
        private readonly IRepository<UserEntity> _repository;
        private readonly IMapper _mapper;

        public LoginService(IRepository<UserEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        public async Task<LoginResponse?> LoginAsync(UserDto userDto)
        {
            UserEntity? userEntity = _repository.GetAll()
                .FirstOrDefault(x => x.Username == userDto.Username && x.Password == userDto.Password);

            if (userEntity == null)
            {
                return null;
            }

            string refreshToken = GenerateJWTSecurityToken(userEntity.Username);

            await UpdateRefreshToken(userEntity, refreshToken);

            return new LoginResponse()
            {
                Token = GenerateJWTSecurityToken(userEntity.Username, 15),
                RefreshToken = refreshToken
            };
        }

        public async Task<LoginResponse?> RefreshAsync(string oldToken)
        {
            UserEntity? userEntity = _repository.GetAll()
                .FirstOrDefault(x => x.RefreshTokens.Any(token => token.Token == oldToken));

            if (userEntity == null)
                return null;

            string refreshToken = GenerateJWTSecurityToken(userEntity.Username);

            await UpdateRefreshToken(userEntity, refreshToken);

            return new LoginResponse()
            {
                Token = GenerateJWTSecurityToken(userEntity.Username, 15),
                RefreshToken = refreshToken
            };
        }

        private async Task UpdateRefreshToken(UserEntity userEntity, string refreshToken)
        {
            userEntity.RefreshTokens.Add(new RefreshTokenEntity() { Token = refreshToken });

            await _repository.UpdateAsync(userEntity);
        }

        private string GenerateJWTSecurityToken(string username, int minutesExpires = 0)
        {
            var secretKey = AuthOptions.GetSymmetricSecurityKey();

            var tokenOptions = new JwtSecurityToken(
                issuer: AuthOptions.ISSUER,
                audience: AuthOptions.AUDIENCE,
                claims: new List<Claim>()
                {
                    new Claim(type: ClaimTypes.Name, value: username)
                },
                expires: minutesExpires == 0 ? null : DateTime.Now.AddMinutes(minutesExpires),
                signingCredentials: new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256));

            return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        }
    }
}
