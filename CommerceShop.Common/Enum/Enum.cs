using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceShop.Common.Enum
{
    public class Enum
    {
        public enum OrderItemStatus
        {
            New = 1,
            Waiting = 2,
            OnShipment = 3,
            Delivered = 4,
            Delayed = 5,
            Cancelled = 6,
            WaitingForPayment = 7
        }

        public enum OrderStatus
        {
            New = 1,
            Waiting = 2,
            OnShipment = 3,
            Delivered = 4,
            Delayed = 5,
            Cancelled = 6,
            WaitingForPayment = 7
        }

        public enum UserStatus
        {
            Active = 1,
            NotActive = 2
        }
    }
}
