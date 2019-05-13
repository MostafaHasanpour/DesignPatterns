namespace DesignPatterns.Structural.AdapterPattern
{
    public class Triangle
    {
        public int BaseT { get; }
        public int Height { get; }

        public Triangle(int baseT, int height)
        {
            BaseT = baseT;
            Height = height;
        }
    }
}
