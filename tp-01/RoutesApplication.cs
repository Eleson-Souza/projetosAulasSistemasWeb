using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace TrabalhoPratico01
{
  public class RotasDaAplicacao
  {
    private Dictionary<string, Func<HttpContext, Task>> Routes;

    public RotasDaAplicacao()
    {
      this.ConfigurarRotas();
    }

    private void ConfigurarRotas()
    {
      this.Routes = new Dictionary<string, Func<HttpContext, Task>>();

      ControllerBook controllerBook = new ControllerBook();

      this.Routes.Add("/livro/NomeLivro", controllerBook.BookName);
      this.Routes.Add("/livro/ToString", controllerBook.ToStringResult);
      this.Routes.Add("/livro/NomesAutores", controllerBook.AuthorsNames);
      this.Routes.Add("/livro/ApresentarLivro", controllerBook.bookPresentation);
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