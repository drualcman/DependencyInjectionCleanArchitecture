using DependencyInyectionMediatR.Application;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionMediatR.Presentation.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMediator Mediator;
        public MessageController(IMediator mediator) => Mediator = mediator;

        [HttpGet]
        public async Task<IActionResult> Send() => Ok(await Mediator.Send(new Ping()));
    }
}
