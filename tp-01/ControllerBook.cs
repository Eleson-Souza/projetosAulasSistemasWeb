using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TrabalhoPratico01.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace TrabalhoPratico01
{
  public class ControllerBook
    {
    public List<Book> Books { get; set; }

    public ControllerBook()
    {
      var books = JsonConvert.DeserializeObject<List<Book>>(
        File.ReadAllText(
          Path.Combine(Directory.GetCurrentDirectory(), "books.json")
        )
      );

      this.Books = books;
    }

    public Task BookName(HttpContext httpContext)
    {
      Book book = this.Books.First();

      var html = File.ReadAllText(Path.Combine(
        Directory.GetCurrentDirectory(),
        "Pages",
        "BookName.html"
      ));

      html = html.Replace("#BOOK_NAME", book.Name);

      return httpContext.Response.WriteAsync(html);
    }

    public Task ToStringResult(HttpContext httpContext)
    {
      Book book = this.Books.First();

      var html = File.ReadAllText(Path.Combine(
        Directory.GetCurrentDirectory(),
        "Pages",
        "ToString.html"
      ));

      html = html.Replace("#RESULT", book.ToString());

      return httpContext.Response.WriteAsync(html);
    }

    public Task AuthorsNames(HttpContext httpContext)
    {
      Book book = this.Books.First();

      var html = File.ReadAllText(Path.Combine(
        Directory.GetCurrentDirectory(),
        "Pages",
        "AuthorsName.html"
      ));

      html = html.Replace("#RESULT", book.AuthorsNames());

      return httpContext.Response.WriteAsync(html);
    }

    public Task bookPresentation(HttpContext httpContext)
    {
      Book book = this.Books.First();

      var html = File.ReadAllText(Path.Combine(
        Directory.GetCurrentDirectory(),
        "Pages",
        "PresentBook.html"
      ));

      html = html.Replace("#BOOK", book.Name);

      string authorsList = "";

      foreach (var author in book.Authors)
      {
        authorsList += "<li>" + author.Name + "</li>";
      }

      html = html.Replace("#RESULT", book.AuthorsNames());
      html = html.Replace("#AUTHORS", authorsList);

      return httpContext.Response.WriteAsync(html);
    }
  }
}