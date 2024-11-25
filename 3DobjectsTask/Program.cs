using System.Diagnostics;

namespace _3DobjectsTask
{
    internal class Program
    {
        static void Main()
        {
            Sphere sphere = new(4f, System.Drawing.Color.AliceBlue, new(1f, 7f, 3f));
            Sphere sphere2 = sphere.Clone();
            sphere2.color = System.Drawing.Color.AntiqueWhite;
            Sphere sphere3 = sphere2.Clone();
            sphere3.color = System.Drawing.Color.DarkSalmon;
            Console.WriteLine(sphere.color);
            Console.WriteLine(sphere2.color);
            Console.WriteLine(sphere3.color);
        }
    }
}
