using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory_Pattern.Interface;

namespace Factory_Pattern.Cards
{
    public class TitaniumCard : ICreditCard
    {
        public string GetCardType()
        {
            return "Titanium Card";
        }
        public int GetCreditLimit()
        {
            return 25000;
        }
        public int GetAnnualCharge()
        {
            return 1500;
        }
    }
}
