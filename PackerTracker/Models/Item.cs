using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Item
  {
    public string Name { get; set; }
    public int Weight { get; set; }
    public int Price { get; set; }
    public int Id { get; }
    private static List<Item> _instances = new List<Item> {};
  

    public Item(string name, int weight, int price)
    {
      Name = name;
      Weight= weight;
      Price = price;
      _instances.Add(this);
      Id = _instances.Count;
    }
  }
}