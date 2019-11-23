using BuilderPattern.Domain;

namespace BuilderPattern.Builders
{
    public class DesktopBuilder : ComputerBuilder
    {        
        public override void AddPart(Part part, int quantity)
        {
            if (Computer == null)
            {
                Computer = new Computer();
            }

            // Add to both the computer and the shopping cart            
            Computer.Parts.Add(part, quantity);

            Cart.Parts.Add(part, (decimal)part * quantity);
        }
    }
}
