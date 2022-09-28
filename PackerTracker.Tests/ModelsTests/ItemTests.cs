using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PackerTracker.Models;
using System;

namespace PackerTracker.Tests
{
 
  [TestClass]
  public class ItemTests : IDisposable
  {
    public Item itemOne;
    public string name;
    public int weight;
    public int price;

    [TestInitialize]
    public void TestInitialize()
    {
      name = "Osprey Hiking Backpack";
      weight = 5;
      price = 150;
      itemOne = new Item(name, weight, price);
    }   

    public void Dispose()
    {
      Item.ClearAll();
    }

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Assert.AreEqual(typeof(Item), itemOne.GetType());
    }

    [TestMethod]
    public void GetName_ReturnName_String()
    {
      string result = itemOne.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetAll_ReturnList_List()
    {
      string nameTwo = "REI Camping Stove";
      int weightTwo = 2;
      int priceTwo = 15;
      Item itemTwo = new Item(nameTwo, weightTwo, priceTwo);
      List<Item> newList = new List<Item> { itemOne, itemTwo };

      List<Item> result = Item.GetAll();
      Console.WriteLine(itemOne.Name);

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void ClearAll_ReturnEmptyList_List()
    {
      itemOne = new Item(name, weight, price);
      
      string nameTwo = "REI Camping Stove";
      int weightTwo = 2;
      int priceTwo = 15;
      Item itemTwo = new Item(nameTwo, weightTwo, priceTwo);
      List<Item> newList = new List<Item> {};
      Item.ClearAll();

      CollectionAssert.AreEqual(Item.GetAll(), newList);
    }

    [TestMethod]
    public void Find_ReturnItemById_Id()
    {
      Assert.AreEqual(Item.Find(1), itemOne);
    }
  }
}