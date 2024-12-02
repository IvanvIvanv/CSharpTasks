namespace FoodOrderTask
{
    internal class Program
    {
        private static void Main()
        {
            IOrder megaOrder = new BaseOrder();
            megaOrder = new FastDeliveryDecorator(megaOrder);
            megaOrder = new FastDeliveryDecorator(megaOrder);
            megaOrder = new GiftPackagingDecorator(megaOrder);
            megaOrder = new AdditionalDrinkDecorator(megaOrder);
            megaOrder = new AdditionalDrinkDecorator(megaOrder);
            megaOrder = new AdditionalDrinkDecorator(megaOrder);
            megaOrder = new FastDeliveryDecorator(megaOrder);
            Console.WriteLine(megaOrder.GetDescription());
            Console.WriteLine(megaOrder.GetPrice());
        }
    }
}
