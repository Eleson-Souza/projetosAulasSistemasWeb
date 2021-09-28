using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace TrabalhoPratico01
{
  public class RoutesApplication
  {
    private Dictionary<string, Func<HttpContext, Task>> Routes;

    public RoutesApplication()
    {
      this.ConfigRoutes();
    }

    private void ConfigRoutes()
    {
      this.Routes = new Dictionary<string, Func<HttpContext, Task>>();

      ControllerBook controllerBook = new ControllerBook();

      this.Routes.Add("/book/BookName", controllerBook.BookName);
      this.Routes.Add("/book/ToString", controllerBook.ToStringResult);
      this.Routes.Add("/book/AuthorsNames", controllerBook.AuthorsNames);
      this.Routes.Add("/book/BookPresentation", controllerBook.bookPresentation);
    }

    public Task Routing(HttpContext httpContext)
    {
      try
      {
        return this.Routes[httpContext.Request.Path].Invoke(httpContext);
      }
      catch (System.Exception ex)
      {
        Console.WriteLine(ex);

        return null;
      }
    }
  }
}