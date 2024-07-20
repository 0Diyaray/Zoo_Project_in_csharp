using System.Security.Cryptography.X509Certificates;

class Animal
{
	public string Species;
	public int Age;
	public int Kg;
	private string _Habitat;
	public string Habitat
		{
		get
		{
			return _Habitat ;
		}
		set
		{
			if (value == "1")
			{
				_Habitat = "Forest";
			}
			else if (value == "2")
			{
				_Habitat = "Water";
			}
			else if (value == "3")
			{ 
				_Habitat = "Desert";	
			}
			else if(value == "4")
			{
				_Habitat = "Polar";
			}
        }
	}
}
class Zoo
{
	public static List<Animal> Animals = new List<Animal>();

	public static void add_to_zoo()
	{ Animal a = new Animal();
		Console.Write("Enter the species: ");
		a.Species = Console.ReadLine();
		Console.WriteLine("Select a habitat:\nHabitat: 1. Forest 2. Water 3. Desert 4. Polar");
		a.Habitat = (Console.ReadLine());
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
		Console.WriteLine("Species Age Kg Habitat");
		Console.WriteLine("------- --- --- ------");
		foreach (var x in Animals)
		{
			Console.WriteLine(x.Species + " " + x.Age + " " + x.Kg+" "+x.Habitat);
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