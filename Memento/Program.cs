namespace MementoPattern
{
    internal class Program
    {
        static void Main()
        {
            Album myAlbum = new();
            myAlbum.images.Push(new Image("MyDog"));
            myAlbum.images.Push(new Image("MyCat"));
            myAlbum.images.Push(new Image("MyFamily"));

            Console.WriteLine(myAlbum.ToString());

            WeirdCamera myCamera = new()
            {
                content = "Landscape"
            };

            myAlbum.images.Push(myCamera.TakePhoto());

            Console.WriteLine(myAlbum.ToString());

            myCamera.LoadPhoto(myAlbum.images.ElementAt(2));

            Console.WriteLine(myCamera.content);
        }
    }
}
