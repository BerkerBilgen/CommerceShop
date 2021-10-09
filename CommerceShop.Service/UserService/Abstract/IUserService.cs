using CommerceShop.Common.Result;
using CommerceShop.Repository.Dto;
using CommerceShop.Repository.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceShop.Service.UserService.Abstract
{
    public interface IUserService
    {
        Task<Result> CreateUser(CreateUserDto createUserDto);
        Task UpdateUser(UpdateUserDto updateUserDto);
        Task<GetUserResponse> GetUser(Guid userId);
        Task<List<GetUserResponse>> GetUserList()
    }
}
