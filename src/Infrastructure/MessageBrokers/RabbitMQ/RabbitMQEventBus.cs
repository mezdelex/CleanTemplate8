namespace Infrastructure.MessageBrokers.RabbitMQ;

public sealed class RabbitMQEventBus(IPublishEndpoint publishEndpoint) : IEventBus
{
    public Task PublishAsync<T>(T message, CancellationToken cancellationToken = default)
        where T : class => publishEndpoint.Publish(message, cancellationToken);
}
