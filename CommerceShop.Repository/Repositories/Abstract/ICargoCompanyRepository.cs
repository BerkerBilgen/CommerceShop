using CommerceShop.Repository.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommerceShop.Repository.Repositories.Abstract
{
    interface ICargoCompanyRepository
    {
        Task CreateCargoCompany(CreateCargoCompanyDto createCargoCompanyDto);

        Task DeleteCargoCompany(Guid cargoCompanyId);

        Task UpdateCargoCompany(UpdateCargoCompanyDto updateCargoCompanyDto);

        Task<CargoCompanyDto> GetCargoCompany(Guid cargoCompanyId);

        Task<List<CargoCompanyDto>> GetCargoCompaniesList();
    }
}
