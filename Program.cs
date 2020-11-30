using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace OneDas.DataManagement
{
    // also interesting: https://github.com/Microsoft/monaco-editor/issues/379
    // also interesting: https://github.com/TypeFox/monaco-languageclient/issues/40
    // also interesting: https://github.com/TypeFox/monaco-languageclient/blob/master/examples/browser/src/client.ts
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
