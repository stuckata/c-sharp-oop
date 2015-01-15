using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Frog : Animal, ISound
{
	public Frog(string name, int age, string gender)
		: base(name, age, gender)
	{
	}
	public void ProduceSound()
	{
		Console.WriteLine("Frog say: Quakkkk.");
	}
}
