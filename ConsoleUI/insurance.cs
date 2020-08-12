using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace NsInsurance
{

    public class Car
    {
        public string CarName { get; set; }
        public int CarId { get; set; }
        public string CarOwner { get; set; }
        public string CarCompany { get; set; }


    }

    public class ClaimInsurance

    {
        public int InsuranceAmount { get; set; }
        public int InsuranceID { get; set; }
        public int InsuranceExpiry { get; set; }
    }

    public class Booking
    {
        public ClaimInsurance Claimed { get; set; }
        public int BookingID { get; set; }

    }
    public class Customers
    {
        public string CustomerName;
        public string CustomerAddress;
        public int CustomerMobileNum;

        public void makepayment()
        {
        }
    }

    public class Payment : Customers

    {
        public int paymentID;

        public void GenerateBill()
        {

        }

    }
}