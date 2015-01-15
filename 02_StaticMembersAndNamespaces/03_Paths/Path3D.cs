using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Path3D
{
	private double coordX;
	private double coordY;
	private double coordZ;

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
	public Path3D(double coordX, double coordY, double coordZ)
	{
		this.CoordX = coordX;
		this.CoordY = coordY;
		this.CoordZ = coordZ;
	}
}

