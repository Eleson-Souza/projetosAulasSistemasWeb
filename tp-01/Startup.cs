using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TrabalhoPratico01
{
  public class Startup
  {
    public void Configure(IApplicationBuilder app)
    {
      var applicationRouter = new RotasDaAplicacao();

      app.Run(applicationRouter.Routing);
    }
  }
}