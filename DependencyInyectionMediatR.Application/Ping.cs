using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInyectionMediatR.Application
{
    public class Ping : IRequest<string>
    {
    }
}
