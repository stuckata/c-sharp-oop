using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TestShapes
{
	static void Main()
	{
		IShape[] shapesArr =
			{
			new Rectangle(2d, 4d),
			new Triangle(3d, 2d, 1d, 2d),
			new Circle(1d)
			};
		foreach (IShape shape in shapesArr)
		{
			Console.WriteLine("Area of {0} is: {1}",shape.GetType(), shape.CalculateArea());
		}
	}
}
