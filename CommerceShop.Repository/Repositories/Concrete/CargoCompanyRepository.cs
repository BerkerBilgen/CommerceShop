using CommerceShop.Data;
using CommerceShop.Data.Entities;
using CommerceShop.Repository.Dto;
using CommerceShop.Repository.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceShop.Repository.Repositories.Concrete
{
    public class CargoCompanyRepository : ICargoCompanyRepository
    {
        private readonly CommerceDbContext _commerceDbContext;

        public CargoCompanyRepository(CommerceDbContext commerceDbContext)
        {
            _commerceDbContext = commerceDbContext;
        }

        public async Task CreateCargoCompany(CreateCargoCompanyDto createCargoCompanyDto)
        {
            var cargoCompany = new CargoCompany()
            {
                Id = Guid.NewGuid(),
                IsActive = true,
                CreatedOn = DateTime.Now,
                Name = createCargoCompanyDto.Name,
                LogoUrl = createCargoCompanyDto.LogoUrl
            };

            _commerceDbContext.CargoCompanies.Add(cargoCompany);

            await _commerceDbContext.SaveChangesAsync();
        }

        public async Task DeleteCargoCompany(Guid cargoCompanyId)
        {
            var cargoCompany = new CargoCompany()
            {
                Id = cargoCompanyId,
                IsActive = false
            };

            _commerceDbContext.CargoCompanies.Add(cargoCompany);

            await _commerceDbContext.SaveChangesAsync();
        }

        public async Task<List<CargoCompanyDto>> GetCargoCompaniesList()
        {
            return _commerceDbContext.CargoCompanies.Select(x => new CargoCompanyDto()
            {
                CargoCompanyId = x.Id,
                LogoUrl = x.LogoUrl,
                Name = x.Name
            }).ToList();
        }

        public async Task<CargoCompanyDto> GetCargoCompany(Guid cargoCompanyId)
        {
            return _commerceDbContext.CargoCompanies.Where(x => x.Id == cargoCompanyId).Select(x => new CargoCompanyDto()
            {
                CargoCompanyId = cargoCompanyId,
                LogoUrl = x.LogoUrl,
                Name = x.Name
            }).FirstOrDefault();
        }

        public async Task UpdateCargoCompany(UpdateCargoCompanyDto updateCargoCompanyDto)
        {
            var cargoCompany = new CargoCompany()
            {
                Id = updateCargoCompanyDto.CargoCompanyId,
                LogoUrl = updateCargoCompanyDto.LogoUrl,
                Name = updateCargoCompanyDto.Name,
                ModifiedOn = DateTime.Now,
                IsActive = true
            };

            _commerceDbContext.CargoCompanies.Add(cargoCompany);

            await _commerceDbContext.SaveChangesAsync();
        }
    }
}
