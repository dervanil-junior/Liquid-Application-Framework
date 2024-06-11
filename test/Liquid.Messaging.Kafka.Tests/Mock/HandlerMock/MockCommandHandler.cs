﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Liquid.Messaging.Kafka.Tests.Mock.HandlerMock
{
    public class MockCommandHandler : IRequestHandler<MockRequest>
    {
        public Task Handle(MockRequest request, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
