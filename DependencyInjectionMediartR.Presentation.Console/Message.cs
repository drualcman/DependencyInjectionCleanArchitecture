using DependencyInyectionMediatR.Application;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionMediartR.Presentation.ConsoleApp
{
    public class Message
    {

        private readonly IMediator Mediator;
        public Message(IMediator mediator) => Mediator = mediator;

        public async Task<string> Send() => await Mediator.Send(new Ping());
    }
}
