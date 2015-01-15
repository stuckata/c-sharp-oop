using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TetsAnimals
{
	static void Main()
	{
		Animal[] animalArr = new Animal[]{
			new Dog("Sharo", 5, "male"),
			new Kitten("Maca", 3),
			new Tomcat("Pisan", 2),
			new Frog("Kvaker", 1, "male"),
			new Dog("Blizzard", 2, "male"),
			new Kitten("Pisana", 6),
			new Tomcat("Myrlio", 7),
			new Frog("Kermit", 2, "male"),
			new Dog("Bobka", 4, "female"),
			new Kitten("Mila", 2),
			new Tomcat("Puhlio", 4),
			new Frog("Yri", 1, "male")
		};

		double avgAgeDog =
			(from dog in animalArr
			 where dog.GetType() == typeof(Dog)
			 select dog.Age).Average();

		double avgAgeFrog =
			(from tom in animalArr
			 where tom.GetType() == typeof(Frog)
			 select tom.Age).Average();

		double avgAgeKitten =
			(from kitty in animalArr
			 where kitty.GetType() == typeof(Kitten)
			 select kitty.Age).Average();

		double avgAgeTomcat =
			(from tom in animalArr
			 where tom.GetType() == typeof(Tomcat)
			 select tom.Age).Average();

		Console.WriteLine("Dog's average age: {0:0.00}", avgAgeDog);
		Console.WriteLine("Frog's average age: {0:0.00}", avgAgeFrog);
		Console.WriteLine("Kitten's average age: {0:0.00}", avgAgeKitten);
		Console.WriteLine("Tomcat's average age: {0:0.00}", avgAgeTomcat);
	}
}
