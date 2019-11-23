using BuilderPattern.Domain;

namespace BuilderPattern.Builders
{
    public abstract class ComputerBuilder
    {
        public ShoppingCart Cart { get; protected set; }
        public Computer Computer { get; protected set; }

        public abstract void AddPart(Part part, int quantity);

        public void OpenCart()
        {
            Cart = new ShoppingCart();
        }
    }
}
