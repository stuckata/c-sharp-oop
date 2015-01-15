using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public static class Storage
{
	public static List<double[]> ReadText(string filePath)
	{
		List<double[]> listPoints3D = new List<double[]>();
		try
		{
			using (StreamReader sr = new StreamReader(filePath))
			{
				String text = sr.ReadToEnd();
				listPoints3D = ExtractPoints(text);
			}
		}
		catch (Exception e)
		{
			Console.WriteLine("The file could not be read:");
			Console.WriteLine(e.Message);
		}
		return listPoints3D;
	}

	private static List<double[]> ExtractPoints(String text)
	{
		List<double[]> listPoints3D = new List<double[]>();

		string[] lines = Regex.Split(text, "[\r\n]+");

		foreach (string line in lines)
		{
			string tempLine = Regex.Replace(line, "^[0-9.- ]", "");
			tempLine = tempLine.Trim();
			string[] nums = Regex.Split(tempLine, ", ");
			double[] coords = new double[nums.Length];
			for (int i = 0; i < nums.Length; i++)
			{
				coords[i] = Double.Parse(nums[i]);
			}
			
			listPoints3D.Add(coords);
		}
		return listPoints3D;
	}
}

