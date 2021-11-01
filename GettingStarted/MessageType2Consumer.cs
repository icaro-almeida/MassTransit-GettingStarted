using System.Threading.Tasks;
using MassTransit;
using Microsoft.Extensions.Logging;

namespace GettingStarted
{

    public class MessageType2Consumer :
        IConsumer<MessageType2>
    {
        readonly ILogger<MessageType2Consumer> _logger;

        public MessageType2Consumer(ILogger<MessageType2Consumer> logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<MessageType2> context)
        {
            _logger.LogInformation("Received Text: {Text} From Author: {Author}", context.Message.Text, context.Message.Author);

            return Task.CompletedTask;
        }
    }
}