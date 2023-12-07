using System.Text.Json;

namespace ProgramowanieObiektoweCzęśćII.WzorceProjektowe.Decorator
{
    class Sender : ISender
    {
        public void Send(IMessage message)
        {
            var jsonString = JsonSerializer.Serialize(message);
            Console.WriteLine($"Sent! Serialized message: \n{jsonString}");
        }
    }
}
