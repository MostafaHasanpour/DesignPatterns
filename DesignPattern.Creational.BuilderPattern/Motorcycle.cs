namespace DesignPattern.Creational.BuilderPattern
{
    //ConcreteBuilder: Motorcycle
    public class Motorcycle : IBuilder
    {
        private string brandName;
        private Product product;

        public Motorcycle(string brand)
        {
            product = new Product();
            this.brandName = brand;
        }

        public void StartUpOperations()
        {
            //Nothing in this case
        }

        public void BuildBody()
        {
            product.Add("This is a body for a Motorcycle");
        }

        public void InsertWheels()
        {
            product.Add("2 wheels are added");
        }

        public void AddHeadlights()
        {
            product.Add("1 Headlight is added");
        }

        public void EndOperations()
        {
            //Finishing up with brandname
            product.Add($"Motorcycle Model name : {this.brandName}");
        }

        public Product GetVehicle()
        {
            return product;
        }
    }
}
