using Factory_Pattern.Interface;

namespace Factory_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cardFactory = new CardFactory();
            ICreditCard cardDetails = cardFactory.GetCardFactory(CardTypeEnum.Gold);
            Console.WriteLine(cardDetails.GetCardType());

            Console.ReadKey();
        }
    }
}
