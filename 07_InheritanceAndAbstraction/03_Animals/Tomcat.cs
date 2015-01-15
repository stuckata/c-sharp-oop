using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Tomcat : Cat, ISound
{
	public Tomcat(string name, int age)
		: base(name, age, "male")
	{
	}

	public void ProduceSound()
	{
		Console.WriteLine("Tomcat say: Miauuu.");
	}
}
