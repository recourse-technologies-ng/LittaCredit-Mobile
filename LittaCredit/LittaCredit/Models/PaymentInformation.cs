using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace LittaCredit.Models
{
    class PaymentInformation : RealmObject
    {
        public BankInformation BankInformation { get; set; }


    }
}
