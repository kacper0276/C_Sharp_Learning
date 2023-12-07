namespace ProgramowanieObiektoweCzęśćII.WzorceProjektowe.Decorator
{
    class SenderDecorator : ISender
    {
        private readonly ISender _sender;

        public SenderDecorator(ISender sender)
        {
            _sender = sender;
        }

        public void Send(IMessage message)
        {
            Console.WriteLine($"Before send {DateTime.UtcNow}");
            _sender.Send(message);
            Console.WriteLine($"After send {DateTime.UtcNow}");
        }
    }
}
