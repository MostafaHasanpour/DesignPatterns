namespace DesignPatterns.Creational.BuilderPattern
{
    //Director
    public class Director
    {
        IBuilder _builder;
        // A series of steps-in real life, steps are complex.
        public void Construct(IBuilder builder)
        {
            _builder = builder;
            builder.StartUpOperations();
            builder.BuildBody();
            builder.InsertWheels();
            builder.AddHeadlights();
            builder.EndOperations();
        }
    }
}
