using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

public class Program
{       
    static void Main(string[] args)
        => WebHost.CreateDefaultBuilder(args)
           .Configure(app => app.Run(ctx => ctx.Response.WriteAsync("Hello World!")))
           .Build().Run();
}
