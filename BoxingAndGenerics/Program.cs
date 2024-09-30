using System.Collections.Generic;
using System.Numerics;

namespace BoxingAndGenerics
{
    internal class Program
    {
        private static void Main()
        {
            #region Task1
            object[] nums = BoxingTask.FillWithIntsAndFloats();
            Console.WriteLine(BoxingTask.Sum(nums));

            Console.WriteLine();
            #endregion

            #region Task2
            Book<string> book = new(
                "Electronics and such", 216, "John David", "Custom string Book Id");

            Console.WriteLine(book.ToString());

            Console.WriteLine(new Book<int>(
                "Time Management or how to keep consistent", 90, "Michael Harrison", 5413).ToString());

            Console.WriteLine(new Book<Guid>(
                "Marketing tips and tricks", 141, "Ann Robinson", new Guid()).ToString());

            Console.WriteLine();
            #endregion

            #region Task3
            Console.WriteLine(new Defaultable<Book<string>>(book).Reset().ToString()); 
            Console.WriteLine(new Defaultable<int>(87).Reset().ToString());

            Console.WriteLine();
            #endregion

            #region Task4
            Circle<int> circle1 = new(Vector2.Zero, 5);
            circle1.SetRadius(5);
            Console.WriteLine(circle1.radius);
            Console.WriteLine(circle1.Area);

            Circle<string> circle2 = new(Vector2.Zero, "7");
            circle1.SetRadius(1);
            Console.WriteLine(circle2.radius);
            Console.WriteLine(circle2.Area);

            Circle<double> circle3 = new(Vector2.Zero, 3.2);
            circle1.SetRadius(89);
            Console.WriteLine(circle3.radius);
            Console.WriteLine(circle3.Area);

            Circle<float> circle4 = new(Vector2.Zero, 2.4f);
            circle1.SetRadius(56);
            Console.WriteLine(circle4.radius);
            Console.WriteLine(circle4.Area);

            Console.WriteLine();
            #endregion

            #region Task5
            Rectangle<string, int> rectangle1 = new(new Vector2(0, 0), "4", 1);
            Console.WriteLine(rectangle1.MinPoint);
            Console.WriteLine(rectangle1.MaxPoint);

            Rectangle<float, double> rectangle2 = new(new Vector2(1.5f, 2.5f), 2.5f, 3.3);
            Console.WriteLine(rectangle2.MinPoint);
            Console.WriteLine(rectangle2.MaxPoint);

            Rectangle<string, float> rectangle3 = new(new Vector2(-2f, 3f), "3", 4.2f);
            Console.WriteLine(rectangle3.MinPoint);
            Console.WriteLine(rectangle3.MaxPoint);

            Circle<double> circle = new(new Vector2(-43f, 12f), 4.84);
            Console.WriteLine(circle.MinPoint);
            Console.WriteLine(circle.MaxPoint);
            #endregion
        }
    }
}