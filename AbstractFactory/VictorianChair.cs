namespace AbstractFactory;

public class VictorianChair : IChair
{

	public bool HasLegs()
	{
		return true;
	}

	public void SitOn()
	{
		Console.WriteLine("Викторианский стул");
	}
}