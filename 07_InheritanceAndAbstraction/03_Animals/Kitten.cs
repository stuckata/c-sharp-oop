using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Kitten : Cat, ISound
{
	public Kitten(string name, int age)
		: base(name, age, "female")
	{
	}
	public void ProduceSound()
	{
		Console.WriteLine("Kitten say: Miaaaaauuuuuuaaaauuuuu.");
	}
}
