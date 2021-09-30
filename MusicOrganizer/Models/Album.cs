using System.Collections.Generic;

namespace MusicOrganizer
{
  public class Album
  {
    public string Description { get; set; }

    private static List<Album> _instances = new List<Album> { };

    public Album(string description)
    {
      Description = description;
      _instances.Add(this);

    }

    public static List<Album> GetAll()
    {
      return _instances;
    }
    // public static void ClearAll()
    // {
    //     _instances.Clear();
    // }

  }
}