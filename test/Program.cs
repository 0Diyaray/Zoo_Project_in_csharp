using System.Security.Cryptography.X509Certificates;

class Animal
{
	public static int _Id = 1;
	public int Id;
	public string Species;
	public int Age;
	public float Kg;
	private string _Habitat;
	public string Habitat
		{
		get
		{
			return _Habitat ;
		}
		set
		{
			while (true)
			{
				if (value == "1")
				{
					_Habitat = "Forest";
					break;
				}
				else if (value == "2")
				{
					_Habitat = "Water";
					break;
				}
				else if (value == "3")
				{
					_Habitat = "Desert";
					break;
				}
				else if (value == "4")
				{
					_Habitat = "Polar";
					break;
				}
				else
				{
					Console.WriteLine("Invalid input.\nShould be between (1-4)\n(1)Forest || (2)Water || (3)Desert || (4)Polar");
					value = Console.ReadLine();
				}
			}
        }
	}
}
class Zoo
{
	public static List<Animal> Animals = new List<Animal>();

	public static void add_to_zoo()
	{ Animal a = new Animal();
		Console.Write("Enter the species(Fish, Bird, Reptile etc.): ");
		a.Id = Animal._Id++;
		a.Species = Console.ReadLine();
		Console.WriteLine("Select a habitat:\nHabitat: 1. Forest 2. Water 3. Desert 4. Polar");
		a.Habitat = (Console.ReadLine());
		Console.Write("Age(ex:25): ");
		a.Age = int.Parse(Console.ReadLine());
		Console.Write("Kg(ex:145,25): ");
		a.Kg = float.Parse(Console.ReadLine());
		Animals.Add(a);
		Console.WriteLine(a.Species + " added");
	}
	public static void delete()
	{
		Console.WriteLine("Enter habitat of the animal to be deleted: ");
		string xy = Console.ReadLine();
		Console.WriteLine($"All {xy} animals listed below.\nSelect by Id");
		Console.WriteLine("Id | Species | Age | Kg | Habitat");
		Console.WriteLine("-------------------------------------------");
		foreach (var x in Animals.Where(x => x.Habitat == xy))
		{ 
			Console.WriteLine(x.Id + " " + x.Species + " " + x.Age + " " + x.Kg);
		}
		Animals.RemoveAll(x => x.Id == int.Parse(Console.ReadLine()));
		Console.WriteLine("Animal deleted");
		}
	public static void list_it()
	{
		Console.WriteLine("Id | Species | Age | Kg | Habitat");
		Console.WriteLine("--- ------- --- --- ------");
		foreach (var x in Animals)
		{
			Console.WriteLine(x.Id+" | "+x.Species + " | " + x.Age + " Age | " + x.Kg + " Kg | "+ x.Habitat);
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
			Console.WriteLine();
		}
	}
}