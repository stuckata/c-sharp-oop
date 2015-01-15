using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class DistanceCalculator
{
	public static double CalcDistance(Point3D p1, Point3D p2)
	{
		return Math.Sqrt((p1.CoordX - p2.CoordX) * (p1.CoordX - p2.CoordX) + 
			(p1.CoordY - p2.CoordY) * (p1.CoordY - p2.CoordY) +
			(p1.CoordZ - p2.CoordZ) * (p1.CoordZ - p2.CoordZ));
	}
}

