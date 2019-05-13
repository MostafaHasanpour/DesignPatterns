namespace DesignPatterns.Structural.AdapterPattern
{
    public class CalculatorAdapter
    {
        public double GetArea(Triangle triangle)
        {
            Calculator c = new Calculator();
            Rectangle rect = new Rectangle();
            rect.Length = triangle.BaseT;
            rect.Width = 0.5 * triangle.Height;
            return c.GetArea(rect);
        }
    }
}
