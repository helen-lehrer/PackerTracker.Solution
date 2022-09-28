using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PackerTracker.Models;
using System;

namespace PackerTracker.Tests
{
  [TestClass]
  public class ItemTests
  {
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      //Arrange
      string name = "Osprey Hiking Backpack";
      int weight = 5;
      int price = 150;

      Item newItem = new Item(name, weight, price);
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    [TestMethod]
    public void GetName_ReturnName_String()
    {
      //Arrange
      string name = "Osprey Hiking Backpack";
      int weight = 5;
      int price = 150;

      //Act
      Item newItem = new Item(name, weight, price);
      string result = newItem.Name;

      //Assert
      Assert.AreEqual(name, result);
    }
  }
}