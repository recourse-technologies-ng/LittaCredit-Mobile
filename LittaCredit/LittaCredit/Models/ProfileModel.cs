using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace LittaCredit.Models
{
    class ProfileModel : RealmObject
    {
        public string CustomerID { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public DateTimeOffset DateOfBirth { get; set; }

        public bool PhoneVerified { get; set; }

        public bool IsActive { get; set; }

        public bool IsBanned { get; set; }

        public float Discount { get; set; }

        public float LoanOffer { get; set; }

        public double BVN { get; set; }

        public BankInformation BankInformation { get; set; }

        public PaymentInformation PaymentInformation { get; set; }
    }
}
