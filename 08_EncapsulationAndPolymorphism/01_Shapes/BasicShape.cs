using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class BasicShape : IShape
{
	public double Width { get; set; }
	public double Height { get; set; }
	public BasicShape(double width, double height)
	{
		this.Width = width;
		this.Height = height;
	}

	public abstract double CalculateArea();
	public abstract double CalculatePerimeter();
}

