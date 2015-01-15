using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TestDistanceCalculator
{
	static void Main(string[] args)
	{
		Point3D p1 = new Point3D(2, 2, 2);
		Point3D p2 = new Point3D(1, 1, 1);
		Console.WriteLine(DistanceCalculator.CalcDistance(p1, p2));
	}
}

