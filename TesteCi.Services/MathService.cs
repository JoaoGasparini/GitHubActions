using TesteCi.Services.Domain.Interfaces;

namespace TesteCi.Services
{
    public class MathService : IMathService
    {
        public int GetDouble(int number)
        {
            return number * 2;
        }
    }
}
