using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Triangle : BasicShape
{
	public double SideB { get; set; }
	public double SideC { get; set; }
	public Triangle(double width, double height, double sideB, double sideC)
		: base(width, height)
	{
		this.SideB = sideB;
		this.SideC = sideC;
	}
	public override double CalculateArea()
	{
		return (Width * Height) / 2;
	}
	public override double CalculatePerimeter()
	{
		return Width + SideB + SideC;
	}
}
