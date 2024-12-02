namespace CoffeeMachineTask
{
    internal class Program
    {
        static void Main()
        {
            CoffeeMachine coffeeMachine = new();
            coffeeMachine.InsertCoin();
            coffeeMachine.SelectDrink();
            coffeeMachine.DispenseDrink();
            coffeeMachine.InsertCoin();

            coffeeMachine.DispenseDrink(); //Throws InvalidOperationException
        }
    }
}
