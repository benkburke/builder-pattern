using BuilderPattern.Domain;

namespace BuilderPattern.Builders
{
    public static class Store
    {
        public static ComputerBuilder SelectModel(ComputerModel model)
        {
            if (model == ComputerModel.Desktop)
            {
                return new DesktopBuilder();
            }
            else
            {
                return new LaptopBuilder();
            }
        }
    }
}
