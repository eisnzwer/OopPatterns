namespace AbstractFactory;

public class VictorianChairFactory : IFurnitureFactory
{

	public IChair CreateChair()
	{
		return new VictorianChair();
	}
}