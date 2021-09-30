namespace MusicOrganizer
{
  public class Album
  {
    public string Description { get; set; }

    public Album(string description)
    {
      Description = description;

    }
    // public static void ClearAll()
    // {
    //     _instances.Clear();
    // }
  }
}