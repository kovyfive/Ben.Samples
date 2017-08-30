using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

public class Program
{
    static void Main() => WebHost.Start(_ => _.Response.WriteAsync("Hello World!")).WaitForShutdown();
}
