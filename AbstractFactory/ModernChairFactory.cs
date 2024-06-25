namespace AbstractFactory;

public class ModernChairFactory : IFurnitureFactory
{

	public IChair CreateChair()
	{
		return new ModernChair();
	}
}