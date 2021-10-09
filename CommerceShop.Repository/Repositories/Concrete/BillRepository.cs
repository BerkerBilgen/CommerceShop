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
    public class BillRepository : IBillRepository
    {
        private readonly CommerceDbContext _commerceDbContext;

        public BillRepository(CommerceDbContext commerceDbContext)
        {
            _commerceDbContext = commerceDbContext;
        }
        public async Task CreateBill(CreateBillDto createBillDto)
        {
            var bill = new Bill()
            {
                Id = Guid.NewGuid(),
                Customer = createBillDto.Customer,
                CreatedOn = DateTime.Now,
                FKOrder = createBillDto.FKOrder,
                IsActive = true,
                PaymentType = createBillDto.PaymentType,
                FKOrderId = createBillDto.FKOrderId
            };

            _commerceDbContext.Bills.Add(bill);

            await _commerceDbContext.SaveChangesAsync();
        }

        public async Task DeleteBill(Guid billId)
        {
            var bill = new Bill()
            {
                Id = billId,
                IsActive = false
            };

            _commerceDbContext.Bills.Add(bill);
            await _commerceDbContext.SaveChangesAsync();
        }

        public async Task<BillDto> GetBill(Guid billId)
        {
            return _commerceDbContext.Bills.Where(x => x.Id == billId).Select(x => new BillDto()
            {
                BillId = x.Id,
                Customer = x.Customer,
                FKCustomerId = x.FKCustomerId,
                FKOrder = x.FKOrder,
                PaymentType = x.PaymentType,
                PaymentDate = x.CreatedOn
            }).FirstOrDefault();
        }

        public async Task<List<BillDto>> GetBillList()
        {
            return _commerceDbContext.Bills.Select(x => new BillDto()
            {
                BillId = x.Id,
                Customer = x.Customer,
                FKCustomerId = x.FKCustomerId,
                FKOrder = x.FKOrder,
                PaymentType = x.PaymentType,
                PaymentDate = x.CreatedOn
            }).ToList();
        }

        public async Task UpdateBill(UpdateBillDto updateBillDto)
        {
            var bill = new Bill()
            {
                Id = updateBillDto.BillId,
                Customer = updateBillDto.Customer,
                CreatedOn = DateTime.Now,
                FKOrder = updateBillDto.FKOrder,
                IsActive = true,
                PaymentType = updateBillDto.PaymentType,
                FKOrderId = updateBillDto.FKOrderId
            };

            _commerceDbContext.Bills.Add(bill);

            await _commerceDbContext.SaveChangesAsync();
        }
    }
}
