using WebSocketSharp;
using WebSocketSharp.Server;

namespace WebSocket.Shared.Messages
{
    public class Pong : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            Send("Ping");
        }
    }
}
