using Factory_Pattern.Cards;
using Factory_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class CardFactory
    {
        public ICreditCard GetCardFactory(CardTypeEnum cardType)
        {
            switch (cardType)
            {
                case CardTypeEnum.Gold:
                    return new GoldCard();
                case CardTypeEnum.Platinum:
                    return new PlatinumCard();
                case CardTypeEnum.Titanium:
                    return new TitaniumCard();
                default:
                    return null;
            }
        }
    }
}
