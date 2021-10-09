using CommerceShop.Common.Result;
using CommerceShop.Repository.Abstract;
using CommerceShop.Repository.Dto;
using CommerceShop.Repository.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceShop.Service.UserService.Concrete
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Result> CreateUser(CreateUserDto createUserDto)
        {
            var result = await _userRepository.CreateUser(createUserDto);
            if (!result.IsSuccess)
                throw new Exception("Creation Failed");

            return result;
        }

        public async Task UpdateUser(UpdateUserDto updateUserDto)
        {
            var result = await _userRepository.UpdateUser(updateUserDto);

            if (!result.IsSuccess)
                throw new Exception("Update is failed");
        }

        public async Task<GetUserResponse> GetUser(Guid userId)
        {
            var result = await _userRepository.GetUser(userId);

            if (result == null)
                throw new Exception("Record Not Found");

            return result;
        }

        public async Task<List<GetUserResponse>> GetUserList()
        {
            var result = await _userRepository.GetUserList();

            if(result == null)
                throw new Exception("No Record Found");
            

            return result; 
        }
    }
}