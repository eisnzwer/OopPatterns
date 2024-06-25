namespace AbstractFactory;

public class ModernChair : IChair
{

	public bool HasLegs()
	{
		return true;
	}

	public void SitOn()
	{
		Console.WriteLine("Современный стул");
	}
}