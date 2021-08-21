using DependencyInyectionMediatR.Application;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DependencyInjectionMediartR.Presentation.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceProvider service = new ServiceCollection()
                .AddMediatR(typeof(Load))
                .BuildServiceProvider();

            Message message = new Message(service.GetService<IMediator>());
            Console.WriteLine(message.Send().Result);
        }
    }
}
