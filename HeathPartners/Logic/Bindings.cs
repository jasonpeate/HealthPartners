using Microsoft.Extensions.DependencyInjection;

namespace Logic
{
    public static class Bindings
    {
        public static void SetupBindings(ServiceCollection ServiceCollection)
        {
            ServiceCollection.AddScoped<IFizzBuzzLogic, FizzBuzzLogic>();
        }
    }
}
