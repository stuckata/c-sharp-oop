using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Circle : IShape
{
	public double Radius { get; set; }
	public Circle(double radius)
	{
		this.Radius = radius;
	}

	public double CalculateArea()
	{
		return Math.PI * Radius * Radius;
	}

	public double CalculatePerimeter()
	{
		return 2 * Math.PI * Radius;
	}
}

