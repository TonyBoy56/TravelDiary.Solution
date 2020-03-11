using System.Collections.Generic;

namespace TravelDiary.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public int Id { get; }
    public static List<Place> Instances { get; } = new List<Place> {};
    public string Journal { get; set; }

    public Place(string cityName, string journal)
    {
      CityName = cityName;
      Instances.Add(this);
      Journal = journal;
      Id = Instances.Count;
    }

    public static void ClearAll()
    {
      Instances.Clear();
    }

    public static Place Find(int searchId)
    {
      return Instances[searchId-1];
    }
  }
}  