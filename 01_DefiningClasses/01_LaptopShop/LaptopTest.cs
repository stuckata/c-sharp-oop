using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LaptopTest
{

	static void Main()
	{
		try
		{
			Laptop laptop = new Laptop();

			Console.Write("Enter laptop manufacturer: ");
			String manufacturer = Console.ReadLine();
			laptop.Manufacturer = manufacturer;

			Console.Write("Enter laptop model: ");
			String model = Console.ReadLine();
			laptop.Model = model;

			Console.Write("Enter laptop processor: ");
			String processor = Console.ReadLine();
			laptop.Processor = processor;

			Console.Write("Enter laptop graphics card: ");
			String graphicsCard = Console.ReadLine();
			laptop.GraphicsCard = graphicsCard;

			Console.Write("Enter laptop screen size: ");
			String screenSize = Console.ReadLine();
			laptop.ScreenSize = screenSize;

			Console.Write("Enter laptop price: ");
			String price = Console.ReadLine();
			laptop.Price = price;

			Battery battery = new Battery();
			Console.Write("Enter laptop battery: ");
			String batteryName = Console.ReadLine();
			battery.BatteryName = batteryName;

			Console.Write("Enter laptop battery life: ");
			String batteryLife = Console.ReadLine();
			battery.BatteryLife = batteryLife;

			laptop.Battery = battery;

			Console.WriteLine(laptop.ToString());
		}
		catch (InvalidDataException e)
		{
			Console.WriteLine("Invalid input data! " + e.Message);
		}

	}

	//static void Main()
	//{
	//	try
	//	{
	//		Console.Write("Enter laptop manufacturer: ");
	//		String manufacturer = Console.ReadLine();

	//		Console.Write("Enter laptop model: ");
	//		String model = Console.ReadLine();

	//		Console.Write("Enter laptop processor: ");
	//		String processor = Console.ReadLine();

	//		Console.Write("Enter laptop graphics card: ");
	//		String graphicsCard = Console.ReadLine();

	//		Console.Write("Enter laptop screen size: ");
	//		String screenSize = Console.ReadLine();

	//		Console.Write("Enter laptop price: ");
	//		String price = Console.ReadLine();

	//		Console.Write("Enter laptop battery: ");
	//		String battery = Console.ReadLine();

	//		Console.Write("Enter laptop battery life: ");
	//		String batteryLife = Console.ReadLine();

	//		Laptop laptop = new Laptop(model, manufacturer, processor, graphicsCard, screenSize, price, battery, batteryLife);
	//		Console.WriteLine(laptop.ToString());
	//	}
	//	catch (InvalidDataException e)
	//	{
	//		Console.WriteLine("Invalid input data! " + e.Message);
	//	}
		
	//}
}

