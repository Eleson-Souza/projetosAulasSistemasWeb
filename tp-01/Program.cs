using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace TrabalhoPratico01
{
  class Program
  {
    static void Main(string[] args)
    {
      TestBook testBook = new TestBook();
      testBook.Test();

      IWebHost host = new WebHostBuilder()
        .UseKestrel()
        .UseStartup<Startup>()
        .Build();

      host.Run();
    }
  }
}
