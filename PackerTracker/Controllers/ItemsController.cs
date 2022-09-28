using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;

namespace PackerTracker.Controllers
{
  public class ItemsController : Controller
  {
    [HttpGet("/items")]
    public ActionResult Index()
    {
      List<Item> allItems = Item.GetAll();
      return View(allItems);
    }

    [HttpPost("/items")]
    public ActionResult Create(string name, int weight, int price)
    {
      Item newGearItem = new Item(name, weight, price);
      return RedirectToAction("Index");
    }

    [HttpGet("/items/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/items/clear")]
    public ActionResult ClearAll()
    {
      Item.ClearAll();
      return RedirectToAction("Index");
    }

    [HttpGet("/items/{id}")]
    public ActionResult Show(int id)
    {
      Item foundItem = Item.Find(id);
      return View(foundItem);
    }

    [HttpPost("/items/{id}")]
    public ActionResult Delete(int id)
    {
      Item.Delete(id);
      return RedirectToAction("Index");
    }
  }
}
