using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

public class Program
{       
    static void Main() => WebHost.Start(ctx => ctx.Response.WriteAsync("Hello World!")).WaitForShutdown();
}
