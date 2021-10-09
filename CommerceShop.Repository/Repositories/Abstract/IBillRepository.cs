using CommerceShop.Repository.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceShop.Repository.Repositories.Abstract
{
    public interface IBillRepository
    {
        Task CreateBill(CreateBillDto createBillDto);

        Task UpdateBill(UpdateBillDto updateBillDto);

        Task DeleteBill(Guid billId);

        Task<BillDto> GetBill(Guid billId);

        Task<List<BillDto>> GetBillList();

    }
}
