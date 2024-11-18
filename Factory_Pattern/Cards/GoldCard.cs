using Factory_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern.Cards
{
    public class GoldCard : ICreditCard
    {
        public string GetCardType()
        {
            return "Gold Card";
        }
        public int GetCreditLimit()
        {
            return 150000;
        }
        public int GetAnnualCharge()
        {
            return 1000;
        }
    }
}
