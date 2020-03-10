using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
        return View();
    }

    [HttpGet("/cars")]
    public ActionResult ShowCars()
    {
        List<Car> cars = Car.GetAll();
        return View(cars);
    }

    [HttpPost("/cars")]
    public ActionResult CreateCar(int year, string make, string model, int miles, int price)
    {
        Car myCar = new Car(year, make, model, miles, price);
        return RedirectToAction("Index");
    }
  }
}