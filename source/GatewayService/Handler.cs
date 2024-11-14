namespace GatewayService;

public class Handler : DelegatingHandler
{
    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        Console.WriteLine(nameof(Handler));
        return base.SendAsync(request, cancellationToken);
    }
}
