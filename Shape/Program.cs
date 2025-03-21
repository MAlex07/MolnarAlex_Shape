namespace Shape
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Rectangle rectangle = new(false, "red", 1, 2);

            Console.WriteLine(rectangle.ToString());

			Shape[] shapes =
			{
				rectangle,
				new Square(true, "blue", 1, 1),
				new Circle(false, 5, "black")
			};


        }
	}
}
