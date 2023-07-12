// See https://aka.ms/new-console-template for more information


using Logic;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
class Program
{
    private static ServiceProvider? serviceProvider;
    private static ILogger? logger;

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Fizz Buzz, Please press any key to process");
        Setup();
        logger.LogDebug("Setup has complete");

        Console.ReadLine();

        logger.LogInformation("Executing FizzBuzz between 1 and 100");

        List<object> input = Enumerable.Range(1, 100).Select(a => (object)a).ToList();

        IFizzBuzzLogic instance = serviceProvider.GetService<IFizzBuzzLogic>();

        logger.LogDebug("Completed Processing");

        List<string> result = instance.Solve(input);

        result.ForEach(a =>
        {
            Console.WriteLine(a);
        });

        Console.WriteLine("Processing Complete, Press any key to exit");

        Console.WriteLine("Thank you for your time!");

        Console.ReadLine();

    }

    static void Setup()
    {
        ServiceCollection sc = new ServiceCollection();
        Bindings.SetupBindings(sc);

        sc.AddLogging((loggingBuilder) => loggingBuilder
                                    .SetMinimumLevel(LogLevel.Trace)
                                    .AddConsole()
                        );

        serviceProvider = sc.BuildServiceProvider();


        logger = serviceProvider.GetService<ILoggerFactory>()
            .CreateLogger<Program>();


    }
}