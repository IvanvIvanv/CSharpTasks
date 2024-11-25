namespace ChatTask
{
    internal class Program
    {
        static void Main()
        {
            GroupChat chat = new();
            chat.Register(new Dog());
            chat.Register(new Parrot());
            Administrator admin = new(chat);
            admin.Broadcast("Hello!");
        }
    }
}
