using System.Security.Cryptography.X509Certificates;

class Animal
{
	public string Species;
	public int Age;
	public int Kg;
}
class Zoo
{
	public static List<Animal> Animals = new List<Animal>();

	public static void add_to_zoo()
	{ Animal a = new Animal();
		Console.Write("Enter the species: ");
		a.Species = Console.ReadLine();
		Console.Write("Age: ");
		a.Age = int.Parse(Console.ReadLine());
		Console.Write("Kg: ");
		a.Kg = int.Parse(Console.ReadLine());
		Animals.Add(a);
		Console.WriteLine(a.Species + " added");
	}
	public static void delete()
	{
		Console.WriteLine("Enter species of the animal to be deleted: ");
		string xy = Console.ReadLine();
		Console.WriteLine($"All {xy} Species listed below");
		Console.WriteLine("-------------------------------------------");
		foreach (var x in Animals.Where(x => x.Species == xy))
		{ 
			Console.WriteLine(x.Species + " " + x.Age + " " + x.Kg); 
		}
		Console.WriteLine("Enter the age of the animal: ");
		int age = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter the kg of the animal: ");
		int kg = int.Parse(Console.ReadLine());
		Animals.RemoveAll(x => x.Species == xy && x.Age == age && x.Kg == kg);
		Console.WriteLine(xy +" deleted");
		}
	public static void list_it()
	{
		Console.WriteLine("Species Age Kg");
		Console.WriteLine("------- --- ---");
		foreach (var x in Animals)
		{
			Console.WriteLine(x.Species + " " + x.Age + " " + x.Kg);
		}
	}
	
}
class Program
{
	private static void Main()
	{
		while (true)
		{
			Console.WriteLine("(1) Add animal\n(2) Delete animal\n(3) List animals\n(4) Exit");
			int x = int.Parse(Console.ReadLine());
			switch (x)
			{
				case 1:
					Zoo.add_to_zoo();
					break;
				case 2:
					Zoo.delete();
					break;
				case 3:
					Zoo.list_it();
					break;
				case 4:
					return;
				default:
					Console.WriteLine("Invalid input");
					break;
			}
		}
	}
}