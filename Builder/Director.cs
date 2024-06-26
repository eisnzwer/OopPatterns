namespace Builder;

public class Director
{
	private ICarBuilder _builder;

	public Director(ICarBuilder builder)
	{ 
		_builder = builder;
	}

	public void Construct()
	{
		_builder.BuildEngine();
		_builder.BuildWheels();
		_builder.BuildBody();
	}
}