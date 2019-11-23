using BuilderPattern.Domain;

namespace BuilderPattern.Builders
{
    public class LaptopBuilder : ComputerBuilder
    {        
        public override void AddPart(Part part, int quantity)
        {
            if (Computer == null)
            {
                Computer = new Computer();
            }

            // Add to both the computer and the shopping cart            
            Computer.Parts.Add(part, quantity);

            // Laptops are more expensive
            Cart.Parts.Add(part, (decimal)part * quantity * 1.25M);
        }
    }
}
