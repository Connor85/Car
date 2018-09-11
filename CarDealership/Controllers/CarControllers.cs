using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CarDealership.Models;
using System;

namespace CarDealership.Controllers
{
  public class CarController : Controller
  {
    //HttpGet method
    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }
    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    [HttpGet("/cars/{price}")]
     public ActionResult Details(int price)
     {
         Car car = Car.Find(price);
         return View(car);
     }

    [HttpPost("/cars")]
    public ActionResult Create()
    {
      Car newCar = new Car (Request.Form["new-car"], int.Parse(Request.Form["new-price"]));
      newCar.Save();
      List<Car> allCars = Car.GetAll();
      return View("Index", allCars);
    }
    [HttpPost("/cars/delete")]
    public ActionResult DeleteAll()
    {
      Car.ClearAll();
      return View();
    }
  }
}
