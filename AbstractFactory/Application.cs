namespace AbstractFactory;

public class Application
{
	private readonly IChair _chair;

	public Application(IFurnitureFactory furnitureFactory)
	{
		_chair = furnitureFactory.CreateChair();
	}

	public void Print()
	{
		_chair.SitOn();
	}
}