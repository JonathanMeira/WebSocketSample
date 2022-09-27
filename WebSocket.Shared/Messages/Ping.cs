using WebSocketSharp;
using WebSocketSharp.Server;

namespace WebSocket.Shared.Messages
{
    public class Ping : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            Send("Pong");
        }
    }
}
