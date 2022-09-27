using WebSocket.Shared.Messages;
using WebSocketSharp.Server;

namespace WebSocket.Service
{
    public class TcpServer : BackgroundService
    {
        private static bool _firstTimeRunningService = true;
        private readonly WebSocketServer _server;

        public TcpServer()
        {
            //TODO: put server ip and port as a configuration in appsettings.json

            _server = new WebSocketServer("ws://127.0.0.1:8080");

            #region Messages

            _server.AddWebSocketService<Ping>("/Ping");
            _server.AddWebSocketService<Pong>("/Pong");

            #endregion
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                if (_firstTimeRunningService)
                {
                    _firstTimeRunningService = false;

                    _server.Start();
                }

                await Task.Delay(1000000000, stoppingToken);
            }
        }
    }
}