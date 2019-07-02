using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace LittaCredit.Models
{
    class BankInformation : RealmObject
    {
        public string BankName { get; set; }

        public string AccountNumber { get; set; }

        public string CardNumber { get; set; }

    }
}
