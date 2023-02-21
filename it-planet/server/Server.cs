using System.Net;
using it_planet.configs;
using it_planet.handler;

namespace it_planet.server;

public class Server
{
    private readonly string SERVER_URL = "http://localhost:";
    private readonly string SERVER_START_MESSAGE = "Server is started!";
    
    private readonly Router _router;
    private readonly HttpListener _listener;
    public Server(Config config, Router router)
    {
        var port = config.GetPort();
        _listener = new HttpListener();
        _router = router;
        _listener.Prefixes.Add(SERVER_URL + port);
    }

    public void Run()
    {
        _listener.Start();
        Console.WriteLine(SERVER_START_MESSAGE);
        while (true)
        {
            var requestContext = new RequestContext(_listener);
            _router.HandleRequest(requestContext);
        }
    }
}