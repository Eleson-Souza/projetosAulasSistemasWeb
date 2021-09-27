using ToolerString;

namespace TrabalhoPratico01.Models
{
  public class Author
  {
    public string Name { get; set; }
    public string Email { get; set; }
    public char Gender { get; set; }

    public override string ToString() => this.ToolerString();
  }
}