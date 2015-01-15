using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TestHumanStudentAndWorker
{
	static void Main()
	{
		List<Student> studentsList = new List<Student>()
		{
			new Student("Ivan", "Ivanov", "25894AFG87"),
			new Student("Georgi", "Georgiev", "13894SFG89"),
			new Student("Gergana", "Pesheva", "184LKSFG87"),
			new Student("Boian", "Bosrisov", "214D4SFG89"),
			new Student("Goran", "Goranov", "26494SFG89"),
			new Student("Stefan", "Penev", "1333LKSG87"),
			new Student("Kaloian", "Dimitrov", "AFG4D4SFG8"),
			new Student("Penka", "Giurova", "1VVB4SFG89"),
			new Student("Diliana", "Liuliakova", "1SDLKAFG65"),
			new Student("Zinedin", "Zidan", "200DAAFH79")
		};

		List<Worker> workersList = new List<Worker>()
		{
			new Worker("Zaprian", "Gerdjikov", 236.40m, 8),
			new Worker("Karakacil", "Georgiev", 300.20m, 8),
			new Worker("Sauron", "Peshev", 238.90m, 8),
			new Worker("Mesi", "Ivanov", 320.10m, 8),
			new Worker("Gandolf", "Dimitrov", 218.30m, 8),
			new Worker("Weiss", "Stefan", 295.41m, 8),
			new Worker("Kamen", "Zagorev", 246.80m, 8),
			new Worker("Feanor", "Fingolfinov", 267.40m, 8),
			new Worker("Galadriel", "Lomidolova", 246.20m, 8),
			new Worker("Saruman", "Beliov", 297.26m, 8)
		};

		List<Human> listAll = new List<Human>();

		var orderedStudents = studentsList.OrderBy(s => s.FaultyNum).ToList();
		var orderedWorkers = workersList.OrderByDescending(w => Worker.CalculateMoneyPerHour(w.WeekSalary, w.WorkHoursPerDay));

		foreach (var st in orderedStudents)
		{
			Console.WriteLine(st);
			listAll.Add(st);
		}

		Console.WriteLine();

		foreach (var w in orderedWorkers)
		{
			Console.WriteLine(w);
			listAll.Add(w);
		}

		Console.WriteLine();

		var orderedList = listAll.OrderBy(h => h.FirstName).ThenBy(h => h.LastName);

		foreach (var h in orderedList)
		{
			Console.WriteLine(h);
		}
	}
}
