using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

	class PCCatalogueTest
	{
		static void Main()
		{
			try
			{
				Component motherBoard = new Component("Motherboard", "Asus", 234.80m);
				Component processor = new Component("Processor", "Intel i5-4790", 498.99m);
				Component ramMemory = new Component("RAM Memory", "A-data 8GB DDR3 1600 MHz", 124.60m);
				Component harddisk = new Component("Hard drive", "Seagate 1TB 7200 64 cache", 110.54m);
				Component videoCard = new Component("Video card", "Asus GT760/2GB", 345.80m);
				Component compCase = new Component("Case", "Fractal Design Black Pearl", 169.87m);
				Component psu = new Component("PSU", "Seasonic 620 Bronze", 148.26m);
				Component soundCard = new Component("Soundcard", "Creative", 134.67m);

				List<Component> componentsComputer1 = new List<Component>();		
				componentsComputer1.Add(motherBoard);
				componentsComputer1.Add(processor);
				componentsComputer1.Add(ramMemory);
				componentsComputer1.Add(harddisk);
				componentsComputer1.Add(videoCard);
				componentsComputer1.Add(compCase);
				componentsComputer1.Add(psu);
				componentsComputer1.Add(soundCard);
				Computer computer1 = new Computer("Computer 1", componentsComputer1);

				Console.WriteLine(computer1.ToString());
			}
			catch (InvalidDataException e)
			{
				Console.WriteLine("Invalid input data! " + e.Message);
			}

		}

	}
