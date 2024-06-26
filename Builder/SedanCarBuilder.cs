namespace Builder;

public class SedanCarBuilder : ICarBuilder
{

	public void BuildEngine()
	{
		Console.WriteLine("Made sedan car engine");
	}

	public void BuildWheels()
	{
		Console.WriteLine("Made sedan car wheels");
	}

	public void BuildBody()
	{
		Console.WriteLine("Made sedan car body");
	}
}