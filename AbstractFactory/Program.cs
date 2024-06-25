namespace AbstractFactory;

class Program
{
	public static void Main(string[] args)
	{
		IFurnitureFactory furnitureFactory;

		string chairType = "Victorian";

		if (chairType == "Victorian")
		{
			furnitureFactory = new VictorianChairFactory();
		}

		else
		{
			furnitureFactory = new ModernChairFactory();
		}

		Application application = new Application(furnitureFactory);
		application.Print();
	}
}