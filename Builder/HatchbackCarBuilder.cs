namespace Builder;

public class HatchbackCarBuilder : ICarBuilder
{

	public void BuildEngine()
	{
		Console.WriteLine("Made hatchback car engine");
	}

	public void BuildWheels()
	{
		Console.WriteLine("Made hatchback car wheels");
	}

	public void BuildBody()
	{
		Console.WriteLine("Made hatchback car body");
	}
}