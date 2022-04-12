using System;
using System.Collections.Generic;

namespace MerchantsDisbursments
{
    public class Merchant
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CIF { get; set; }
    }

    public class Shoppers
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string NIF { get; set; }
    }

    public class Orders
    {
        public int ID { get; set; }
        public int MercharntID { get; set; }
        public int ShopperID { get; set; }
        public long Amount { get; set; }
        public DateTime CretedAt { get; set; }
        public DateTime CompletedAt { get; set; }
    }

    public class DisbursementsPerWeek
    {
        public int MercharntID { get; set; }
        public long Amount { get; set; }
        public DateTime FirstWeekDay { get; set; }
    }
}
