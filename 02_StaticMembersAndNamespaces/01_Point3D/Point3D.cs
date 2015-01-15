using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Point3D
{
	private double coordX;
	private double coordY;
	private double coordZ;
	private static readonly Point3D startingPoint = new Point3D(0, 0, 0);

	public static Point3D StartingPoint
	{
		get
		{
			return startingPoint;
		}
	}
	public double CoordX
	{
		get { return this.coordX; }
		set { this.coordX = value; }
	}
	public double CoordY
	{
		get { return this.coordY; }
		set { this.coordY = value; }
	}
	public double CoordZ
	{
		get { return this.coordZ; }
		set { this.coordZ = value; }
	}
	public Point3D(double coordX, double coordY, double coordZ)
	{
		this.CoordX = coordX;
		this.CoordY = coordY;
		this.CoordZ = coordZ;
	}
	public override string ToString()
	{
		return  "[" + this.coordX + ", " + this.coordY + ", " + this.coordZ + "]";
	}
}

