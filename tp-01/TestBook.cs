using System;
using TrabalhoPratico01.Models;
using Newtonsoft.Json;

namespace TrabalhoPratico01
{
  public class TestBook
  {
    public Book Book { get; set; }

    public void Test()
    {
      this.Book = new Book();

      this.Book.Name = "Nome do livro";
      this.Book.Price = 129;
      this.Book.Quantity = 35;

      this.Book.Authors.Add(new Author()
      {
        Name = "Manuel Bandeira",
        Email = "autho1r@mail.com",
        Gender = 'M',
      });

      this.Book.Authors.Add(new Author()
      {
        Name = "Clarice Lispector",
        Email = "author2@mail.com",
        Gender = 'F',
      });

      Console.Write("Nomes dos Autores : ");
      Console.WriteLine(this.Book.AuthorsNames());

      Console.Write("ToString : ");
      Console.WriteLine(this.Book.ToString());
    }
  }
}