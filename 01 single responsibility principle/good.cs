public class Book
{
  public string Author { get; set; }
 
  public string Title { get; set; }
}
 
public class DataService
{
  public void Save(Book book)
  {
    // save to the database
  }
}