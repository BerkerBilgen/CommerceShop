using CommerceShop.Common.Result;
using CommerceShop.Repository.Dto;
using CommerceShop.Repository.Requests;
using CommerceShop.Repository.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceShop.Repository.Abstract
{
   public interface IUserRepository
    {
        Task<Result> CreateUser(Dto.CreateUserDto createUserRequest);

        Task<Result> UpdateUser(UpdateUserDto updateUserRequest);

        Task<GetUserResponse> GetUser(Guid userId);
        Task<List<GetUserResponse>> GetUserList();
    }
}
