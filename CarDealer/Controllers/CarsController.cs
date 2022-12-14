using Microsoft.AspNetCore.Mvc;
using CarDealer.Models;

namespace CarDealer.Controllers
{
  public class CarsController : Controller
  {
    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetLot();
      return View(allCars);
    }

    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpGet("/cars/delete")]
    public ActionResult DeleteForm()
    {
      return View();
    }

    [HttpPost("/cars")]
    public ActionResult Create(string model, string price, string miles)
    {
      Car myCar = new Car(model, price, miles);
      return RedirectToAction("Index");
    }

    [HttpPost("/cars/delete")]
    public ActionResult Delete(string model)
    {
      Car.RemoveCar(model);
      return RedirectToAction("Index");
    }
  }
}