namespace DesignPatterns.Structural.AdapterPattern
{
    public class Calculator
    {
        public double GetArea(Rectangle rect)
        {
            return rect.Length * rect.Width;
        }
    }
}
