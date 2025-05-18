using System.Globalization;
using System.Text;

namespace MinimalApi;

public sealed class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        var app = builder.Build();

        app.MapGet("/", () => "Hello World!");

        app.Run();
    }

    public void Configure(IApplicationBuilder builder)
    {
        builder.UseOwin(pipeline => {
            pipeline(next => OwinHello);
        });
    }

    public Task OwinHello(IDictionary<string, object> environment)
    {
        const string ResponseText = "OWIN World";
        var responseBytes = Encoding.UTF8.GetBytes(ResponseText);

        var responseStream = (Stream)environment["owin.ResponseBody"];
        var responseHeaders = (IDictionary<string, string[]>)environment["owin.ResponseHeaders"];

        responseHeaders["Content-Length"] = [responseBytes.Length.ToString(CultureInfo.InvariantCulture)];
        responseHeaders["Content-Type"] = ["text/plain"];

        return responseStream.WriteAsync(responseBytes, 0, responseBytes.Length);
    }
}
