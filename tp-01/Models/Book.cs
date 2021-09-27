using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TrabalhoPratico01.Models;
using ToolerString;

namespace TrabalhoPratico01.Models
{
  public class Book
  {
    public Book()
    {
      this.Authors = new List<Author>();
    }

    public string Name { get; set; }
    public IList<Author> Authors { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public string AuthorsNames()
    {
      string name = this.Authors.First().Name;

      foreach (var autor in this.Authors.Skip(1))
        name += "," + autor.Name;

      return name;
    }

    public override string ToString() => this.ToolerString();
  }
}