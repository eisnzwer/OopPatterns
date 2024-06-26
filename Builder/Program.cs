namespace Builder;

class Program
{
	public static void Main(string[] args)
	{
		ICarBuilder sedanCarBuilder = new SedanCarBuilder();
		Director sedanDirector = new Director(sedanCarBuilder);
		sedanDirector.Construct();

		Console.WriteLine();

		ICarBuilder hatchBackCarBuilder = new HatchbackCarBuilder();
		Director hatchbackDirector = new Director(hatchBackCarBuilder);
		hatchbackDirector.Construct();
	}
}