using CommerceShop.Common.Result;
using CommerceShop.Data;
using CommerceShop.Data.Entities;
using CommerceShop.Repository.Abstract;
using CommerceShop.Repository.Dto;
using CommerceShop.Repository.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CommerceShop.Common.Enum.Enum;

namespace CommerceShop.Repository.Concrete
{
    public class UserRepository : IUserRepository
    {
        private readonly CommerceDbContext _commerceDbContext;

        public UserRepository(CommerceDbContext commerceDbContext)
        {
            _commerceDbContext = commerceDbContext;
        }
        public async Task<Result> CreateUser(Dto.CreateUserDto createUserRequest)
        {
            var result = new Result();
            var user = new User
            {
                UserId = Guid.NewGuid(),
                Name = createUserRequest.FirstName,
                LastName = createUserRequest.LastName,
                Email = createUserRequest.Email,
                BirthDate = createUserRequest.BirthDate,
                FKRoleId = createUserRequest.RoleId,
                Password = createUserRequest.Password,
                Title = createUserRequest.Title
            };

            _commerceDbContext.Users.Add(user);

            await _commerceDbContext.SaveChangesAsync();
            result.IsSuccess = true;
            result.Message = "Successfully Created";

            return result;
        }

        public async Task<GetUserResponse> GetUser(Guid userId)
        {
            var userResponse = new GetUserResponse();
            userResponse = _commerceDbContext.Users.Where(x => x.UserId == userId).Select(x => new GetUserResponse
            {
                UserId = x.UserId,
                Email = x.Email,
                FirstName = x.Name,
                LastName = x.LastName,
                BirthDate = x.BirthDate,
                Password = x.Password,
                RoleId = x.FKRoleId
            }).FirstOrDefault();

            return userResponse;
        }

        public async Task<Result> UpdateUser(UpdateUserDto updateUserRequest)
        {
            var result = new Result();
            var user = new User
            {
                UserId = updateUserRequest.UserId,
                Name = updateUserRequest.FirstName,
                LastName = updateUserRequest.LastName,
                Email = updateUserRequest.Email,
                BirthDate = updateUserRequest.BirthDate,
                FKRoleId = updateUserRequest.RoleId,
                Password = updateUserRequest.Password,
                Title = updateUserRequest.Title,
                Status = updateUserRequest.Status
            };

            _commerceDbContext.Users.Add(user);
            await _commerceDbContext.SaveChangesAsync();

            result.IsSuccess = true;
            result.Message = "Succesfully Updated";

            return result;

        }

        public async Task<List<GetUserResponse>> GetUserList()
        {
            return _commerceDbContext.Users.Where(x => x.Status == (int)UserStatus.Active).Select(x => new GetUserResponse()
            {
                BirthDate = x.BirthDate,
                Email = x.Email,
                FirstName = x.Name,
                LastName = x.LastName,
                Password = x.Password,
                UserId = x.UserId,
                PersonalImage = x.PersonalImage
            }).ToList();
        }
    }
}
